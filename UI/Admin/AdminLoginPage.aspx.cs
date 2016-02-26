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
    public partial class AdminLoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                UserManager um = new UserManager();
                UserManagerBLL bll = new UserManagerBLL();
                string userName = Request["username"];
                string passWord = Request["password"];
                um = bll.GetUserManagerByUserName(userName);
                if (um.UserName == userName && um.UserPwd == passWord)
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    Response.Redirect("Error.html");
                }
            }
        }
    }
}