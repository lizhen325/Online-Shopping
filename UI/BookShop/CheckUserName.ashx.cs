using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using BookShopBLL;

namespace UI.BookShop
{
    /// <summary>
    /// Summary description for CheckUserName
    /// </summary>
    public class CheckUserName : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            UserInfo ui = new UserInfo();
            string userName = context.Request["userName"];
            UserInfoBLL bll = new UserInfoBLL();
            ui = bll.GetUserInfoByUserName(userName);
            if (ui == null)
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