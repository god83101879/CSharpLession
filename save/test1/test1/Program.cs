using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using test3;

namespace test1
{
    class Program
    {
        public void Main() //測試join跟string[]
        {
            //    string[] test = new string[5] {"A","AA","AAA","BBBB","AAAAA"};
            //    string readcoladd = string.Join("幹", test);
            //    Console.Write(readcoladd);
            //    Console.Read();
            //}
            //static void Main(string[] args)
            //{
            //    string connectionString = "Data Source = localhost\\SQLEXPRESS;Initial Catalog = CSharpLesson; Integrated Security = true";

            //    string queryString = $@"SELECT * FROM Personals  ORDER BY PersonalID;";

            //    SqlConnection connection = new SqlConnection(connectionString);
            //    SqlCommand command = new SqlCommand(queryString, connection);  //接connection不接connectionString 因已經指派給connection

            //    //command.Parameters.AddWithValue("@PersonalID", "2");

            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("\t{0}\t{1}\t{2}", reader["PersonalID"], reader["PersonalAccount"], reader["PersonalPassword"]); // /t空格 {012}為引數
            //    }
            //    reader.Close();
            //    connection.Close();
            //    Console.ReadLine();
            //}
            //static void Main(string[] args)
            //{
            //    //string connectionString = "Data Source = localhost\\SQLEXPRESS;Initial Catalog = CSharpLesson; Integrated Security = true";

            //    //string queryString = $@"INSERT INTO webtb (Account, Pwd, Name)  VALUES (@Account, @Pwd, @Name);";

            //    //using (SqlConnection connection = new SqlConnection(connectionString))
            //    //{
            //    //    SqlCommand command = new SqlCommand(queryString, connection);  //接connection不接connectionString 因已經指派給connection

            //    //    //command.Parameters.AddWithValue("@ID", "");
            //    //    command.Parameters.AddWithValue("@Account", "a1234511");
            //    //    command.Parameters.AddWithValue("@Pwd", "5432111");
            //    //    command.Parameters.AddWithValue("@Name", "Jhong11");

            //    //    connection.Open();
            //    //    //int totalChangeRows = command.ExecuteNonQuery();
            //    //    SqlDataReader reader = command.ExecuteReader();
            //    //    DataTable dt = new DataTable();
            //    //    dt.Load(reader);
            //    //    Console.WriteLine();
            //    //    Console.Read();
            //    //    //foreach (DataRow dr in dt.Rows)
            //    //    //{
            //    //    //    Console.WriteLine("\t{0}\t{1}\t{2},", dr["Account"], dr["Pwd"], dr["Name"]);
            //    //    //    Console.Read();
            //    //    //}
            //    //    reader.Close();
            //    //    //Console.WriteLine("Total change" + totalChangeRows + "Rows.");
            //    //    //connection.Close();

            //    //}

            //    ABC();  //方法呼叫
            //int result = RandomPeople.ADD(6, 8); //呼叫自己專案裡的其他方法
            //int result = Another.Add(10, 7);
            //Console.Write(result);
            //Console.Read();


    }


    }
}
