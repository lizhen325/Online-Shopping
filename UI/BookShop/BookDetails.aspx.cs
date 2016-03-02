using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookShopBLL;
using Model;

namespace UI.BookShop
{
    public partial class BookDetails : System.Web.UI.Page
    {
        public BookInfo biModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request["id"]);
            BookInfoBLL bll = new BookInfoBLL();
            biModel = bll.GetBookInfoById(id);
        }
    }
}