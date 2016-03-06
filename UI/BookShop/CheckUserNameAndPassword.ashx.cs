using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using BookShopBLL;

namespace UI.BookShop
{
    /// <summary>
    /// Summary description for CheckUserNameAndPassword
    /// </summary>
    public class CheckUserNameAndPassword : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            UserInfoBLL bll = new UserInfoBLL();
            string id = context.Request["id"];
            string email = context.Request["email"];
            UserInfo ui = null;
            ui = bll.ForGetPassword(id, email);
            if(ui == null)
            {
                context.Response.Write("no");
            }
            else
            {
                context.Response.Write("ok");
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