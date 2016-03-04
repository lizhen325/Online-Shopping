using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShopBLL;
using Model;

namespace UI.BookShop
{
    /// <summary>
    /// Summary description for CartInfoDelete
    /// </summary>
    public class CartInfoDelete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int cid = int.Parse(context.Request["cid"]);
            CartInfoBLL bll = new CartInfoBLL();
            if(bll.DeleteCartInfoById(cid))
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