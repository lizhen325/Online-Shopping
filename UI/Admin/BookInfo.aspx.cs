using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookShopBLL;
using Model;
using System.Text;

namespace UI.Admin
{
    public partial class BookInfo : System.Web.UI.Page
    {
        protected string PageBar { get; set; }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            BookInfoBLL bll = new BookInfoBLL();
            int pageIndex = 1;
            int pageSize = 8;
            if (!string.IsNullOrEmpty(Request["pIndex"]))
            {
                pageIndex = int.Parse(Request["pIndex"]);
            }
            int rowsCount = bll.GetRecordCount("");
            int pageCount = Convert.ToInt32(Math.Ceiling(rowsCount * 1.0 / pageSize));
            if (pageIndex <= 1)
            {
                pageIndex = 1;
            }
            if (pageIndex >= pageCount)
            {
                pageIndex = pageCount;
            }
            int startIndex = (pageIndex - 1) * pageSize + 1;
            int endIndex = pageIndex * pageSize;
            Repeater1.DataSource = bll.GetListByPage("", "Id", startIndex, endIndex);
            Repeater1.DataBind();

            StringBuilder sb = new StringBuilder();
            sb.Append("<ul class='pagination'>");
            sb.Append("<li><a href='?pIndex=1'> << </a></li>");
            for (int i = 1; i <= pageCount; i++ )
            {
                if(i == pageIndex)
                {
                    sb.Append("<li class='active'><a href='?pIndex=" + i + "'>" + i + "</a></li>");
                }
                else
                {
                    sb.Append("<li><a href='?pIndex=" + i + "'>" + i + "</a></li>");
                }
                
            }
            sb.Append("<li><a href='?pIndex="+pageCount+"'> >> </a></li>");
            sb.Append("</ul>");
            PageBar = sb.ToString();
        }
    }
}