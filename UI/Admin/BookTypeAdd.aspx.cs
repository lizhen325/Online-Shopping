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
    public partial class BookTypeAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BookType bt = new BookType();
            bt.TypeTitle = Request["title"];
            bt.TypeParentId = Convert.ToInt32(Request["pid"]);
            BookTypeBLL bll = new BookTypeBLL();
            
        }
    }
}