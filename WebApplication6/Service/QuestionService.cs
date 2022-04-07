using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication6.Models;
//insert into dbo.Questions (question,answerA,answerB,answerC,answerD,correctAnswer) values ('Koja je NBA franšiza prva u povijesti potpisala tamnoputog igrača?','Phoenix Suns','San Antonio Spurs','Boston Celtics','Miami Heat','Boston Celtics');
namespace WebApplication6.Service
{
    public class QuestionService
    {
        String connectionString = @"Data Source=(localdb)\local;Initial Catalog=projectwebquiz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        int id;

        public void setId(int x)
        {
            id = x;
        }

        public String GetQuestion()
        {
            String question = null;
            String sql = "SELECT question FROM dbo.Questions where Id = @id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int, 40).Value = id;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            question = reader[0].ToString();
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return question;
        }
        public String GetAnswerA()
        {
            String answer = null;
            String sql = "SELECT answerA FROM dbo.Questions where Id = @id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int, 40).Value = id;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            answer = reader[0].ToString();
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return answer;
        }
        public String GetAnswerB()
        {
            String answer = null;
            String sql = "SELECT answerB FROM dbo.Questions where Id = @id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int, 40).Value = id;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            answer = reader[0].ToString();
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return answer;
        }
        public String GetAnswerC()
        {
            String answer = null;
            String sql = "SELECT answerC FROM dbo.Questions where Id = @id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int, 40).Value = id;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            answer = reader[0].ToString();
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return answer;
        }
        public String GetAnswerD()
        {
            String answer = null;
            String sql = "SELECT answerD FROM dbo.Questions where Id = @id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int, 40).Value = id;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            answer = reader[0].ToString();
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return answer;
        }
        public String GetCorectAnswer()
        {
            String answer = null;
            String sql = "SELECT answerD FROM dbo.Questions where Id = @id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int, 40).Value = id;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            answer = reader[0].ToString();
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return answer;
        }
    }
}
