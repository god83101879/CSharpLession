using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sqlwork
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
               "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLesson; Integrated Security=true";

            string queryString =
                $@" SELECT * FROM TestTable1
                    WHERE NumberCol = @NumberCol 
                    ORDER BY ID DESC;";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@NumberCol", "3");

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            "\t{0}\t{1}\t{2}",
                            reader["ID"],
                            reader["Birthday"],
                            reader["Name"]
                        );
                    }

                    reader.Close();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message); //每個動作都印出訊息
                }
                finally 
                {
                    connection.Close(); //全部做完關掉，以防佔記憶體
                }
            }
        }
    }
}
