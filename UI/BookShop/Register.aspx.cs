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
    public partial class Register : System.Web.UI.Page
    {
        protected UserInfo ui { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                UserInfo ui = new UserInfo();
                ui.UserName = Request["userid"].Trim();
                ui.UserPwd = UI.Common.MD5Encrypt.MD5Check(Request["password"]);
                ui.Email = Request["email"];
                ui.Address = Request["address"];
                ui.MobilePhone = Request["mobilephone"];
                ui.RegisterTime = System.DateTime.Now;
                ui.LoginTime = System.DateTime.Now;
                ui.State = 0;
                UserInfoBLL bll = new UserInfoBLL();
                if(bll.InsertUserInfo(ui))
                {
                    Session["user"] = ui.UserName;
                    //Session["id"] = ui.UserId;
                    Context.Response.Redirect("Activation.aspx");
                }
                else
                {
                    Context.Response.Redirect("Error.html");
                }
            }
        }
    }
}