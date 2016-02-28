using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShopBLL;

namespace UI.Admin
{
    /// <summary>
    /// Summary description for BookInfoDelete
    /// </summary>
    public class BookInfoDelete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["id"]);
            BookInfoBLL bll = new BookInfoBLL();
            if(bll.DeleteBookInfoById(id))
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