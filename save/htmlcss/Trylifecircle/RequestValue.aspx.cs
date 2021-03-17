using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

namespace Trylifecircle
{
    public partial class RequestValue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string qsVal = this.Request.QueryString["Page"];
            //string postVal = this.Request.Form["Account"];
            //string accept = this.Request.Headers["Accept-Language"];

            ////var gs1 = HttpContext.Current.Request.QueryString["Page"];
            //Uri reqUrl = this.Request.Url;
            //string rawUrl = this.Request.RawUrl;
            //string referrer = this.Request.UrlReferrer?.ToString();

            //Response.Write(rawUrl + "<br/>");
            //Response.Write(referrer + "<br/>");

            //this.ListAllContent(this.Request.QueryString);
            //this.ListAllContent(this.Request.Form);
            //this.ListAllContent(this.Request.Headers);

            //string[] pageColl = this.Request.QueryString.GetValues("Page");

            GotoErrorPage("Error");
        }

        //private void ListAllContent(NameValueCollection collection)
        //{
        //    foreach (var key in collection.AllKeys)
        //    {
        //        var value = collection[key];
        //        Response.Write($"Key:{key}, Value:{value}<br/>");
        //    }
        //}

        public static void GotoErrorPage(string msg)
        {
            HttpContext.Current.Response.StatusCode = 400;
            //丟錯誤訊息
            HttpContext.Current.Response.Write(msg);
            //將Buffer中的內容送出
            HttpContext.Current.Response.Flush();
            //忽視之後透過Resionse.Write輸出的內容
            HttpContext.Current.Response.SuppressContent = true;
            //忽視之後ASP.NET Pipeline的處理步驟，直接跳關到EndRequest
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
    }
}