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
            if (IsPostBack)
            {
                BookType bt = new BookType();
                bt.TypeTitle = Request["title"];
                bt.TypeParentId = int.Parse(Request["pid"]);
                BookTypeBLL bll = new BookTypeBLL();
                if (bll.InsertBookType(bt))
                {
                    Response.Redirect("../BookTypeList.aspx");
                }
                else
                {
                    Response.Redirect("Error.html");
                }
            }
        }
    }
}