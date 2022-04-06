using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.Service
{
    public class UserRegistration
    {
        String connectionString = @"Data Source=(localdb)\local;Initial Catalog=projectwebquiz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        bool success = false;

        public bool SaveUserToDatabase(UserModel userModel)
        {
            UsersDAO usersDAO = new UsersDAO();
            if (usersDAO.FindByUsernameAndPassword(userModel) == true)
            {
                // user with that name already exists
                success = false;
            }
            else
            {
                String sql = "insert into dbo.Users values (@user,@pass);";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add("@user", System.Data.SqlDbType.VarChar, 40).Value = userModel.Username;
                    command.Parameters.Add("@pass", System.Data.SqlDbType.VarChar, 40).Value = userModel.Password;

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        success = true;
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }

            }

            return success;
        }
    }
}