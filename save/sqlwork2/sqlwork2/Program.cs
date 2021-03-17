using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sqlwork
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
               "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLesson; Integrated Security=true";

            string queryString = // +@符號可分行 
                $@" INSERT INTO TestTable1   
                        (ID, Name, Birthday, NumberCol)
                    VALUES
                        (@ID, @Name, @Birthday, @NumberCol)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection); //
                command.Parameters.AddWithValue("@ID", 8); //AddWithValue 的 object可以放任何東西 記得不可重複第一個值
                command.Parameters.AddWithValue("@Name", "學武");
                command.Parameters.AddWithValue("@Birthday", new DateTime(1995, 5, 1));
                command.Parameters.AddWithValue("@NumberCol", "3");

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //int totalChangeRows = command.ExecuteNonQuery();
                    //Console.WriteLine("Total Change" + totalChangeRows + "Rows.");
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine(
                            "\t{0}\t{1}\t{2}",
                            dr["ID"],
                            dr["Birthday"],
                            dr["Name"]
                            );
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); //每個動作都印出訊息
                    Console.ReadLine();
                }
                /*finally
                {
                    connection.Close(); //全部做完關掉，以防佔記憶體
                }*/
            }
        }
    }
}
