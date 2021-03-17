using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppandAPP
{
    public class DBTool
    {
        public static DataTable ReadTestTable1DT()
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
                command.Parameters.AddWithValue("@NumberCol", "3");

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); //每個動作都印出訊息
                    return null;
                }
            }
        }

        public static DataTable BulidDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Birthday", typeof(DateTime));
            dt.Columns["Birthday"].AllowDBNull = true;

            DateTime baseDate = new DateTime(2021, 1, 1);
            for (var i = 0; i < 50; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = i;
                dr["Name"] = "UserName" + i;
                dr["Birthday"] = baseDate.AddDays(i);
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public static void InsertIntoTestTable1(string ID, string Name, string Birthday, string number)
        {
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLesson; Integrated Security=true";

            string queryString = $@"INSERT INTO TestTable1
                                        (ID, Name, Birthday, NumberCol)
                                    VALUES
                                        (@ID, @Name, @Birthday, @NumberCol)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Birthday", Birthday);
                command.Parameters.AddWithValue("@NumberCol", number);


                try
                {
                    connection.Open();
                    int totalChangRows = command.ExecuteNonQuery();
                    Console.WriteLine("Total chang" + totalChangRows + " Rows.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }

        public static void DeleteTestTablel(string id)
        {
            string connectionstring = "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLesson; Integrated Security=true";

            string queryString =
                $@"DELETE FROM TestTable1 WHERE ID=@ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();
                    int totalChangeRows = command.ExecuteNonQuery();
                    HttpContext.Current.Response.Write("Total change" + totalChangeRows + "Rows");
                }

                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex.Message);
                }
            }
        }
    }
}