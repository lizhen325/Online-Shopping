using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Admin
{
    /// <summary>
    /// Summary description for UserManagerRemove
    /// </summary>
    public class UserManagerRemove : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["id"]);
            BookShopBLL.UserInfoBLL bll = new BookShopBLL.UserInfoBLL();
            if (bll.RemoveUserInfoById(id))
            {
                context.Response.Write(1);
            }
            else
            {
                context.Response.Write(0);
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