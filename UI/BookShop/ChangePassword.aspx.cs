using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BookShopBLL;
using System.Text;

namespace UI.BookShop
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected string Notice { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserInfoBLL bll = new UserInfoBLL();
                string id = Request["id"];
                string email = Request["email"];
                UserInfo ui = bll.GetUserInfoByUserName(id);
                string MessageFrom = "zhenli336@gmail.com";
                string MessageTo = email;
                string MessageSubject = "ChangePassword from Bookshop";
                StringBuilder MessgeBody = new StringBuilder();
                MessgeBody.Append("Hi," + id);
                MessgeBody.Append("<br>BookShop receive a request to reset the password for your account");
                MessgeBody.Append("<br> To reset your password, click on the below");
                MessgeBody.Append("<br>http://localhost:61877/BookShop/ResetPassword.aspx?id=" + id + "&email="+email);
                MessgeBody.Append("<br>Have a great day");
                MessgeBody.Append("<br>Team Book Shop");
                Common.SendMail sm = new Common.SendMail();
                bool flag = sm.Send(MessageFrom, MessageTo, MessageSubject, MessgeBody.ToString());
                if (flag == true)
                {
                    Session["user"] = id;
                    Notice = ("Hello <b style='color:red;'>" + id + "</b> Welcome to BookShopStall. Please reset your password from your Email");
                }
            }    
        }
    }
}