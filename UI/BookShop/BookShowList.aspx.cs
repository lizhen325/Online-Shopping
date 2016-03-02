using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BookShopBLL;
using System.Data;

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
            int pageSize = 10;
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
            PageBar = UI.Common.PageHelper.GetNumericPage(pageIndex, pageCount);
        }
    }
}