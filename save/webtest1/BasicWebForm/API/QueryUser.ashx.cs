using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BasicWebForm.Models;
using Newtonsoft.Json;

namespace BasicWebForm.API
{
    /// <summary>
    /// QueryUser 的摘要描述
    /// </summary>
    public class QueryUser : IHttpHandler
    {
        //class UserInfo
        //{
        //    public string UserName { get; set; }
        //    public int Age { get; set; }
        //    public string Sex { get; set; }
        //}

        List<UserInfo> _list = new List<UserInfo>()
        {
            new UserInfo() { UserName = "John", Age = 17, Sex="Female"},
            new UserInfo() { UserName = "Mary", Age = 16, Sex="Female"},
            new UserInfo() { UserName = "Johnny", Age = 18, Sex ="Male"},
        };
        public void ProcessRequest(HttpContext context)
        {
            //string result = Newtonsoft.Json.Convert.SerializeObject(this._list);
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            //string result = @"[{""UserName"": ""John"",""Age"":17,""Sex"": ""Female""},
            //                  {""UserName"": ""Mary"",""Age"":16,""Sex"": ""Female""},
            //                  {""UserName"": ""Johnny"",""Age"":18,""Sex"": ""Male""}]";
            string pName = context.Request.QueryString["name"];
            //var tempList = (from item in this._list where item.UserName.Contains(pName) select item).ToList();
            var tempList = DataBaseExecutor.GetUserInfos(pName);
            //string result = JsonConvert.SerializeObject(this._list);
            string result = JsonConvert.SerializeObject(tempList);
            context.Response.ContentType = "application/json"; //mime type 非路徑
            context.Response.Charset = "utf-8";
            context.Response.Write(result);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}