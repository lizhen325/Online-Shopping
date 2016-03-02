using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using BookShopBLL;

namespace UI.BookShop
{
    /// <summary>
    /// Summary description for CheckUserEmail
    /// </summary>
    public class CheckUserEmail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            UserInfoBLL bll = new UserInfoBLL();
            UserInfo ui = new UserInfo();
            context.Response.ContentType = "text/plain";
            string email = context.Request["email"];
            ui = bll.GetUserInfoByEmail(email);
            if(ui == null)
            {
                context.Response.Write("ok");
            }
            else
            {
                context.Response.Write("no");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}