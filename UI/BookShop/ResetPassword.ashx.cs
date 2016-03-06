using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using BookShopBLL;

namespace UI.BookShop
{
    /// <summary>
    /// Summary description for ResetPassword1
    /// </summary>
    public class ResetPassword1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string password = Common.MD5Encrypt.MD5Check(context.Request["password"]);
            string id = context.Request["id"];
            UserInfo ui = new UserInfo();
            ui.UserName = id;
            ui.UserPwd = password;
            UserInfoBLL bll = new UserInfoBLL();
            if(bll.UpdatePassword(ui))
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