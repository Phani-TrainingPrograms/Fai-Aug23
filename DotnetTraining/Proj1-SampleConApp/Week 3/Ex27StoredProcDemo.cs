using System;
using System.Configuration;
using System.Data.SqlClient;
namespace Proj1_SampleConApp.Week_3
{
    class Ex27StoredProcDemo
    {
        static readonly string CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        const string STRCREATEEMPLOYEE = "CreateEmployee";
        const string STRUPDATEEMPLOYEE = "UpdateEmployee";
        static void Main(string[] args)
        {
            insertToDb();
            //updateToDb();
            deleteFromDb();
        }

        private static void deleteFromDb()
        {
            //call the ExecuteNonQuery and delete the record.
            //throw new NotImplementedException();
        }

        private static void ExecuteNonQuery(string connectionString, string procName, params SqlParameter[] parameters)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            foreach(var parameter in parameters)
            {
                //cmd.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
                cmd.Parameters.Add(parameter);
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
        private static void updateToDb()
        {
            int id = 1000;
            string name = "Soujanya N.D.";
            string address = "Shimoga";
            double salary = 65000;
            int deptId = 3;
            SqlParameter pm1 = new SqlParameter("@empName", name);
            SqlParameter pm2 = new SqlParameter("@empAddress", address);
            SqlParameter pm3 = new SqlParameter("@empSalary", salary);
            SqlParameter pm4 = new SqlParameter("@deptId", deptId);
            SqlParameter pm5 = new SqlParameter("@empId", id);
            try
            {
                ExecuteNonQuery(CONNECTIONSTRING, STRUPDATEEMPLOYEE, pm1, pm2, pm3, pm4, pm5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void insertToDb()
        {
            string name = "Phaniraj";
            string address = "Bangalore";
            double salary = 45000;
            int deptId = 3;
            int generatedId = 0;
            
            
            var pm1 = new SqlParameter("@empName", name);
            var pm2 = new SqlParameter("@empAddress", address);
            var pm3 = new SqlParameter("@empSalary", salary);
            var pm4 = new SqlParameter("@deptId", deptId);
            var pm5 = new SqlParameter("@empId", generatedId);
            pm5.Direction = System.Data.ParameterDirection.Output;
            try
            {
                ExecuteNonQuery(CONNECTIONSTRING, STRCREATEEMPLOYEE, pm1, pm2, pm3, pm4, pm5);
                Console.WriteLine("The ID is " + pm5.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }   
    }
}
//todo: Create a Patient Record System to store the Patient details along with the Doctor name. A report has to be generated on the Number of patients visited per doctor and their details. The Application is created using C# and DB connection using stored procedures. The App should follow the Factory pattern and perform all the operations. 

