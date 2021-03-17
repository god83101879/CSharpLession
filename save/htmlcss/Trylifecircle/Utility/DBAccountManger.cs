using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Trylifecircle.Utility
{
    public class DBAccountManger
    {
        public static DataTable GetUserAccount(string account)
        {
            string connectionString =
               "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLesson; Integrated Security=true";

            string queryString = // +@符號可分行 
                $@" SELECT * FROM UserAccount WHERE Account = @account";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection); //
                command.Parameters.AddWithValue("@account", account);

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
    }
}