using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;//For SQL Server database...

namespace Proj1_SampleConApp.Week_2
{
    class EmpData
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }
        public int? DeptId { get; set; }
    }
    
    class Ex26_ConnectedDataAccess
    {
        const string STRSELECT = "SELECT * FROM EMPTABLE";
        const string STRCONNECTION = @"Data Source =.\SQLEXPRESS;Initial Catalog = FaiTraining; Integrated Security = True";
        #region HELPERS
        private void NonQueryExecute(string query, SqlParameter[] parameters, CommandType type)
        {
            
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = type;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        private DataTable GetRecords(string query, SqlParameter[] parameters, CommandType type = CommandType.Text)
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = type;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable("Records");
                table.Load(reader);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        static List<EmpData> getAllEmployees()
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(STRSELECT, con);
            List<EmpData> records = new List<EmpData>();
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var emp = new EmpData
                    {
                        EmpId = Convert.ToInt32(reader[0]),
                        EmpName = reader[1].ToString(),
                        EmpAddress = reader[2].ToString(),
                        EmpSalary = Convert.ToDouble(reader[3]),
                        DeptId = Convert.IsDBNull(reader[4]) ? 0 : Convert.ToInt32(reader[4])
                    };
                    records.Add(emp);
                }
            }catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return records;
        }
        static void readAllRecords()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = STRCONNECTION;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = STRSELECT;
            cmd.Connection = con; //HAS- A RELATION
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["empName"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            //readAllRecords();
            //insertRecord("Aditya", "Mysore", 45000, 2);
            //var records = getAllEmployees();
            //foreach(var emp in records)
            //    Console.WriteLine(emp.EmpName + " earns a salary of Rs. " + emp.EmpSalary);

            //updateRecord(1001, "TstName", "TestAddress", 6000, 4);

            //deleteRecord(1001);
        }

        private static void deleteRecord(int id)
        {
            string query = $"Delete from EmpTable Where EmpId = {id}";
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 1)
                {
                    Console.WriteLine("Employee deleted successfully");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private static void updateRecord(int v1, EmpData data)
        {
            string query = $"Update EmpTable Set empName = '{data.EmpName}', empAddress = '{data.EmpAddress}', empSalary = {data.EmpSalary}, deptId = {data.DeptId} where EmpId = {v1}";
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 1)
                {
                    Console.WriteLine("Employee updated successfully");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private static void updateRecord(int v1, string v2, string v3, int v4, int v5)
        {
            string query = $"Update EmpTable Set empName = '{v2}', empAddress = '{v3}', empSalary = {v4}, deptId = {v5} where EmpId = {v1}";
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 1)
                {
                    Console.WriteLine("Employee updated successfully");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private static void insertRecord(string name, string address, int salary, int dept)
        {
            string query = $"Insert into Emptable values('{name}','{address}', {salary}, {dept})";
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows == 1)
                {
                    Console.WriteLine("Employee inserted successfully");
                }
            }   
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
//todo: As 70% of the code is reused in our functions, we need 2 APIs for DML(Insert, delete and update) and DQL(SELECT). Create 2 APIs that will take the required inputs and perform the operation and call it in main method. 