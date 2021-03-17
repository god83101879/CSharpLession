using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data; //使用DataTable需使用

namespace weekhw2
{
    public class SQL //方法宣告，只能有一個
    {
        public static DataTable readTable(string readtable, string[] readcol) //DataTable(String, String)括號內表之後使用此方法需用到的命名使用指定的資料表名稱和命名空間，初始化 DataTable 類別的新執行個體。
        { //readTable只是命名的資料表名稱
            string connectionString = "Data Source = localhost\\SQLEXPRESS;Initial Catalog=CSharpLesson; Integrated Security=true";  //連結資料庫第一小段為連結位址、第二小段為連接的資料庫名稱、第三小段為
            // Integrated Security=true 使用Windows驗證的方式去連接到數據庫服務器。這樣方式的好處是不需要在連接字符串中編寫用戶名和密碼，從一定程度上說提高了安全性。
            string readcoladd = string.Join(",", readcol); //string.Join將接來的readcol字串用"，"連結成一個字串
            string ordername = ""; //判斷接來的readtable來決定那個表的排序方式
            if (readtable == "Personals")
            {
                ordername = "PersonalID";
            }
            else if (readtable == "Projects")
            {
                ordername = "ProjectID";
            }
            else if (readtable == "WorkItems")
            {
                ordername = "WorkItemID";
            }
            else
            {
                HttpContext.Current.Response.Write("請輸入正確資料表名稱"); //回傳錯誤訊息
            }
            //SQL語法參數化
            string queryString = $@" SELECT {readcoladd} FROM {readtable} ORDER BY {ordername}"; //選擇readcoladd資料 從readtable表單 以ordername排序

            using (SqlConnection connection = new SqlConnection(connectionString)) //連結資料庫擷取所有資料右邊為字串指定到左邊為記憶體空間，using為括號內使用完就釋放記憶體空間，以免佔用到其他資源
            {
                SqlCommand command = new SqlCommand(queryString, connection); //用於儲存和執行SQL資料庫的SQL語句
                try // 欲執行的程式碼
                {
                    connection.Open(); //資料庫打開
                    SqlDataReader reader = command.ExecuteReader();  //command指令，讀取並建構資料表指定給reader
                    DataTable dt = new DataTable();  // 建立新的DataTable
                    dt.Load(reader); //從DataSet取得資料，並存至DataTable的dt內
                    reader.Close(); //方法關閉，釋放資源
                    return dt;
                }  
                catch (Exception ex)  // 當錯誤發生時，欲執行的程式碼
                {
                    HttpContext.Current.Response.Write("" + ex); //回報當前錯誤訊息
                    return null; //回報傳錯
                }
            }
        }
        public static void InsertTable(string readtable, string[] insertcol, string[] insertcolp, List<string> personalinsert)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CSharpLesson; Integrated Security=true";
            //將接來的字串用"，"連結成一個字串
            string insertcolum = string.Join(",", insertcol);
            string insertparameter = string.Join(",", insertcolp); //插入範圍
            string queryString = "";
            //將user輸入的集合轉為陣列
            string[] ppersonalinsert= personalinsert.ToArray();

            queryString = $@" INSERT INTO {readtable} ({insertcolum}) VALUES ({insertparameter})"; //沒@表欄位名稱 有@表值 將值賦予至queryString
            //利用connection插入、修改
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    for (int i = 0; i < insertcolp.Length; i++)
                    {
                        command.Parameters.AddWithValue($"{insertcolp[i]}", ppersonalinsert[i]); //command資料庫指令 Parameters參數中的方法 AddWithValue 此時是做將@值變為字串值
                    }
                    connection.Open(); //資料庫打開
                    command.ExecuteNonQuery(); //ExecuteNonQuery用來執行將值放進去
                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write("" + ex);
                }
            }
        }
        public static void UpdateTable(string readtable, string[] updatecol, string wherep, string[] updatecolp, List<string> personalupdate) //List< String >:泛型，非定長，可變，不確定字串長度時使用。
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CSharpLesson; Integrated Security=true";
            //將接來的字串用"，"連結成一個字串
            string updatecolum = string.Join(",", updatecol);
            string queryString = "";
            //將user輸入的集合轉為陣列
            string[] ppersonalupdate = personalupdate.ToArray();
            queryString = $@" UPDATE {readtable} SET {updatecolum} WHERE {wherep}";

            //利用connection修改
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    for (int i = 0; i < updatecolp.Length; i++)
                    {
                        command.Parameters.AddWithValue($"{updatecolp[i]}", ppersonalupdate[i]);
                    }
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write("" + ex);
                }
            }
        }
        public static void DeleteTable(string readtable, string target, string targetp, string personaldelete)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CSharpLesson; Integrated Security=true";
            string queryString = $"DELETE FROM {readtable} WHERE {target} = {targetp}";

            //利用connection插入、修改
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue(targetp, personaldelete); 
                try
                {
                    connection.Open();
                    int totalchangeRows = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write("" + ex);
                }
            }
        }
    }
}