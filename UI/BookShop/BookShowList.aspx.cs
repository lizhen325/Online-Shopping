using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BookShopBLL;
using System.Data;
using System.Text;

namespace UI.BookShop
{
    public partial class BookShowList : System.Web.UI.Page
    {
        public List<BookInfo> BookList { get; set; }
        public string PageBar { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            BookInfoBLL bll = new BookInfoBLL();
            BookInfo bi = new BookInfo();
            int pageIndex = 1;
            int pageSize = 12;
            int rowsCount = bll.GetRecordCount("");
            int pageCount = Convert.ToInt32(Math.Ceiling(rowsCount * 1.0 / pageSize));
            if(!string.IsNullOrEmpty(Request["pIndex"]))
            {
                pageIndex = int.Parse(Request["pIndex"]);
                if(pageIndex <= 1)
                {
                    pageIndex = 1;
                }
                if(pageIndex >= pageCount)
                {
                    pageIndex = pageCount;
                }
            }
            DataTable dt = bll.GetListByPage("", "", (pageIndex-1)*pageSize+1, pageIndex*pageSize).Tables[0];
            BookList = new List<BookInfo>();
            foreach(DataRow dr in dt.Rows)
            {
                BookList.Add(new BookInfo()
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    ImgTitle = dr["imgTitle"].ToString(),
                    BookTitle = dr["Title"].ToString(),
                    SubTitle = dr["SubTitle"].ToString(),
                    PriceOld = Convert.ToDecimal(dr["PriceOld"].ToString()),
                    PriceNew = Convert.ToDecimal(dr["PriceNew"].ToString()),
                    Author = dr["Author"].ToString(),
                    Details = dr["Details"].ToString()
                });
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("<ul class='pagination'>");
            sb.Append("<li><a href='?pIndex=1'> << </a></li>");
            for (int i = 1; i <= pageCount; i++)
            {
                if (i == pageIndex)
                {
                    sb.Append("<li class='active'><a href='?pIndex=" + i + "'>" + i + "</a></li>");
                }
                else
                {
                    sb.Append("<li><a href='?pIndex=" + i + "'>" + i + "</a></li>");
                }

            }
            sb.Append("<li><a href='?pIndex=" + pageCount + "'> >> </a></li>");
            sb.Append("</ul>");
            PageBar = sb.ToString();
        }
    }
}