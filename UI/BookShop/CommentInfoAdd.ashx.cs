using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using BookShopBLL;

namespace UI.BookShop
{
    /// <summary>
    /// Summary description for CommentInfoAdd
    /// </summary>
    public class CommentInfoAdd : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["id"]);
            string msg = context.Request["content"];
            CommentInfo ci = new CommentInfo();
            ci.BookId = id;
            ci.CoomentMsg = msg;
            ci.CommentTime = DateTime.Now;
            BookShopBLL.CoomentBLL bll = new CoomentBLL();
            if(bll.InsertCommentList(ci))
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