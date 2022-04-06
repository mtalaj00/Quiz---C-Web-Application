using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.Service
{
    public class UsersDAO
    {
        String connectionString = @"Data Source=(localdb)\local;Initial Catalog=projectwebquiz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public bool FindByUsernameAndPassword(UserModel userModel)
        {
            bool success = false;

            String sql = "SELECT * FROM dbo.Users where username = @user and password = @pass;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql,connection);
                command.Parameters.Add("@user", System.Data.SqlDbType.VarChar, 40).Value = userModel.Username;
                command.Parameters.Add("@pass", System.Data.SqlDbType.VarChar, 40).Value = userModel.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
            return success;
        }
    }
}