using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace htmlcss
{
    public partial class UserControltest : System.Web.UI.UserControl
    {
        public int PagingSize { get; set; } = 10; //預設10筆
        public int PageIndex { get; set; } = 1;
        public int TotalSize { get; set; } = 10;
        public string Url { get; set; }
        public enum SourceType
        {
            Inner = 0,
            Outter = 1
        }

        public SourceType Stype { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }

        public void Bind()
        {
            int currentPageIndex = Convert.ToInt32(Request.QueryString["Page"]);

            //總頁數
            int pages = TotalSize / PagingSize + 1;

            this.ltCurrentPage.Text = (currentPageIndex + 1).ToString();
            this.ltTotalPage.Text = pages.ToString();

            this.aLinkFirst.HRef = this.BuildPagingUrl(1);
            this.aLinkLast.HRef = this.BuildPagingUrl(pages);
            this.aPage1.HRef = this.BuildPagingUrl(1);
            this.aPage2.HRef = this.BuildPagingUrl(2);
            this.aPage3.HRef = this.BuildPagingUrl(3);
        }
        string BuildPagingUrl(int pageIndex)
        {
            return $"{Url}?Page ={pageIndex}";
        }
    }
}