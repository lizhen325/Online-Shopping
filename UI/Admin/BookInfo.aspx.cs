using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookShopBLL;
using Model;

namespace UI.Admin
{
    public partial class BookInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BookInfoBLL bll = new BookInfoBLL();
            Repeater1.DataSource = bll.GetAllBookInfo();
            Repeater1.DataBind();
        }
    }
}