using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Trylifecircle.Utility
{
    public class loginhelper
    {
        private const string _sessionKey = "IsLogined";
        private const string _sessionKey_Account = "Account";
        /// <summary>
        /// 檢查是否有登入
        /// </summary>
        /// <returns></returns>
        public static bool HasLogined()
        {
            bool? val = HttpContext.Current.Session[_sessionKey] as bool?;
            if (val.HasValue && val.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool TryLogin(string account, string password)
        {
            if (loginhelper.HasLogined())
            {
                return true;
            }
            // Get user account from DB
            DataTable dt = DBAccountManger.GetUserAccount(account);

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }

            //bool isAccountRight = string.Compare("jhong", account, true) == 0; //==0表毫無差距
            string dbpwd = dt.Rows[0].Field<string>("Pwd");
            string dbName = dt.Rows[0].Field<string>("Name");
            //bool isPasswordRight = string.Compare("syuewu", password) == 0;
            bool isPasswordRight = string.Compare(dbpwd, password) == 0;

            //if (isAccountRight && isPasswordRight)
            if (isPasswordRight)
            {
                //HttpContext.Current.Session[_sessionKey_Account] = account;
                HttpContext.Current.Session[_sessionKey_Account] = dbName;
                HttpContext.Current.Session[_sessionKey] = true;

                return true;
            }
            else 
            {
                return false;
            }
        }
        /// <summary>
        /// 執行登出，登出目前使用者，如果還沒登入就不執行
        /// </summary>
        public static void Logout()
        {
            if (!loginhelper.HasLogined())
            {
                return;
            }

            HttpContext.Current.Session.Remove(_sessionKey);
            HttpContext.Current.Session.Remove(_sessionKey_Account);
        }
        /// <summary>
        /// 取得已登入者的資訊，如果還沒登入傳回空字串
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentUserInfo()
        {
            if (!loginhelper.HasLogined())
            {
                return string.Empty;
            }
            else
            {
                return HttpContext.Current.Session[_sessionKey_Account] as string;
            }
        }
    }
}