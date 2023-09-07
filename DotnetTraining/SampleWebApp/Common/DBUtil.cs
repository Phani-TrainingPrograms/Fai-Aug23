using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;

public static class DbUitl
{
    public static int ValidateUser(string username, string password, string otp)
    {
        //todo: using connected model, check the username and password, return true for valid data and false for invalid data.
        //Connect to the db, validate the uname and password
        //if valid, update the otp and expirydate into the database
        var con = new SqlConnection(ConfigurationManager.ConnectionStrings["FaiTrainingConnectionString1"].ConnectionString);
        var query = $"Select Id from UserTable where UserName = '{username}' and Password = '{password}'";
        var cmd = new SqlCommand(query, con);
        try
        {
            con.Open();
            var obj = cmd.ExecuteScalar();
            if (obj == null)
            {
                throw new Exception("Invalid Credentials");
            }
            var id = (int)obj;//boxed data...
            updateOtp(id, otp);
            return id;
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            con.Close();
        }
        throw new Exception("No User found");
    }

    private static bool updateOtp(int id, string otp, bool remove = false)
    {
        if (remove == false)
        {
            string insertQuery = $"Update UserTable Set Otp = '{otp}', Expiry = '{DateTime.Now.AddMinutes(5)}' Where Id = {id}";
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["FaiTrainingConnectionString1"].ConnectionString);
            var cmd = new SqlCommand(insertQuery, con);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected == 1;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        else
        {
            string insertQuery = $"Update UserTable Set Otp = '', Expiry = NULL Where Id = {id} And Otp = '{otp}'";
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["FaiTrainingConnectionString1"].ConnectionString);
            var cmd = new SqlCommand(insertQuery, con);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return (rowsAffected == 1);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

    }
    public static string GenerateOtp()
    {
        var otp = "";
        Random random = new Random();
        for (int i = 0; i < 6; i++)
        {
            Thread.Sleep(10);
            otp += random.Next(0, 9).ToString();
        }
        return otp;

    }

    public static bool ValidateOtp(int id, string inputOtp)
    {
        return updateOtp(id, inputOtp, true);
    }


}