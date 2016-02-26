using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BookShopBLL;

namespace UI.Admin
{
    public partial class UserManagerAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfoBLL bll = new UserInfoBLL();
            UserInfo ui = new UserInfo();
            ui.UserName = Request["txtName"];
            ui.UserPwd = Request["txtPwd"];
            ui.Email = Request["txtEmail"];
            ui.Address = Request["txtAddress"];
            ui.MobilePhone = Request["txtMobilePhone"];
            ui.RegisterTime = System.DateTime.Now;

            bool flag = bll.InsertUserInfo(ui);
            if(flag)
            {
                Context.Response.Write("ok");
            }
            else
            {
                Context.Response.Write("no");
            }
        }
    }
}