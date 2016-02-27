using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShopBLL;
using Model;

namespace UI.Admin
{
    /// <summary>
    /// Summary description for BookTypeDelete
    /// </summary>
    public class BookTypeDelete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["id"]);
            BookTypeBLL bll = new BookTypeBLL();
            if(bll.DeleteBookType(id))
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