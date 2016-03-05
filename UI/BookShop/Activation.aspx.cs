using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookShopBLL;
using Model;
using System.Text;

namespace UI.BookShop
{
    public partial class Activation : System.Web.UI.Page
    {
        public string Notice { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfoBLL bll = new UserInfoBLL();
            
            if(!IsPostBack)
            {
                if(Session["user"] == null)
                {
                    Response.Redirect("Register.aspx");
                }
                string userName = "";              
                userName = Session["user"].ToString();               
                UserInfo ui = bll.GetUserInfoByUserName(userName);
                string MessageFrom = "zhenli336@gmail.com";
                string MessageTo = ui.Email;
                string MessageSubject = "Activation from Bookshop";
                StringBuilder MessgeBody = new StringBuilder();
                MessgeBody.Append("Hi," + ui.UserName);
                MessgeBody.Append("<br>Than you for signning up for BookShop");
                MessgeBody.Append("<br> please help us make sure we add you to the right website by verifying your email address");
                MessgeBody.Append("<br>http://localhost:61877/BookShop/ComfirmActivation.aspx?username="+ui.UserName+"");
                MessgeBody.Append("<br>Have a great day");
                MessgeBody.Append("<br>Team Book Shop");
                Common.SendMail sm = new Common.SendMail();
                bool flag = sm.Send(MessageFrom, MessageTo, MessageSubject, MessgeBody.ToString());
                if (flag == true)
                {
                    Notice = ("Hello <b style='color:red;'>" + ui.UserName + "</b> Welcome to BookShopStall. Please activate your Account from your Email");
                }                
            }            
        }
    }
}