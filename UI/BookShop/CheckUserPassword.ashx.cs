﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using BookShopBLL;
using System.Web.SessionState;

namespace UI.BookShop
{
    /// <summary>
    /// Summary description for CheckUserPassword
    /// </summary>
    public class CheckUserPassword : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string username = context.Request["username"];
            string password = UI.Common.MD5Encrypt.MD5Check(context.Request["password"]);
            UserInfo ui = new UserInfo();
            UserInfoBLL bll = new UserInfoBLL();
            ui = bll.GetUserInfoByUserNameAndUserPassword(username, password);
            if(ui != null)
            {
                context.Session["user"] = username;
                context.Session["id"] = ui.UserId;
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