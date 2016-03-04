using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BookShopBLL;
using Model;

namespace UI.BookShop
{
    public partial class CartInfoList : System.Web.UI.Page
    {
        protected DataTable dt { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Common.SessionValidate.IsLogin())
            {
                Response.Redirect("/BookShop/Register.aspx");
            }
            CartInfoBLL bll = new CartInfoBLL();
            int customerId = Convert.ToInt32(Session["id"]);
            dt = bll.GetAllCartInfo(customerId);
        }
    }
}