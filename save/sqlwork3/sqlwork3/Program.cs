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

        /*static void Main(string[] args)
        {
            DataTable dt = BulidDataTable(); //老師已寫入DataBaseExecutor.cs 所以這裡不用+
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine("\t{0}\t{1}",
                    dr["ID"],
                    dr["Name"]
                    );
            }
            Console.ReadLine();
        }*/

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
    }
}
