using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BookShopBLL;

namespace UI.BookShop
{
    public partial class ComfirmActivation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["user"] == null)
                {
                    Response.Redirect("Register.aspx");
                }
                UserInfoBLL bll = new UserInfoBLL();
                string username = Request["username"];
                UserInfo ui = bll.GetUserInfoByUserName(username);
                ui.State = 1;
                ui.UserName = username;
                if(bll.UpdateUserInfoByUerName(ui))
                {
                    Response.Redirect("SuccessActivation.aspx");
                }
                else
                {
                    Response.Redirect("Error.html");
                }            
            }
        }
    }
}