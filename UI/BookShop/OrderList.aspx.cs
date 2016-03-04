using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Model;
using BookShopBLL;

namespace UI.BookShop
{
    public partial class OrderList : System.Web.UI.Page
    {
        protected string OrderCode { get; set; }
        protected DataTable DtCartInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!Common.SessionValidate.IsLogin())
            //{

            //}
            int CId = Convert.ToInt32(Session["id"]);
            if(!IsPostBack)
            {              
                OrderCode = DateTime.Now.ToString("yyyyMMddHHmmss") + Session["id"];
                CartInfoBLL bll = new CartInfoBLL();
                DtCartInfo = bll.GetAllCartInfo(CId);
            }
        }
    }
}