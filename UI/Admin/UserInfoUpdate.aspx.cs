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
    public partial class UserInfoUpdate : System.Web.UI.Page
    {
        protected UserInfo ui { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfoBLL bll = new UserInfoBLL();
            if(IsPostBack)
            {
                UserInfo ui = new UserInfo();
                ui.UserId = int.Parse(Request["uid"]);
                ui.UserName = Request["username"];
                ui.Email = Request["email"];
                ui.Address = Request["address"];
                ui.MobilePhone = Request["mobilephone"];
                if(bll.UpdateUserInfoById(ui))
                {
                    Response.Redirect("UserManagerList.aspx");
                }
                else
                {
                    Response.Redirect("Error.html");
                }
            }
            else
            {
                int id = int.Parse(Request["id"]);
                ui = bll.GetUserInfoById(id);
            }
        }
    }
}