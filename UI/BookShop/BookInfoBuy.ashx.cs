using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using BookShopBLL;
using Model;

namespace UI.BookShop
{
    /// <summary>
    /// Summary description for BookInfoBuy
    /// </summary>
    public class BookInfoBuy : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if(!Common.SessionValidate.IsLogin())
            {
                //need log in
                context.Response.Write(2);
                return;
            }
            int bookId = int.Parse(context.Request["id"]);
            decimal priceNew = Convert.ToDecimal(context.Request["priceNew"]);
            int customerId = Convert.ToInt32(context.Session["id"]);
            int count = int.Parse(context.Request["count"]);
            CartInfo ci = new CartInfo();
            ci.BookId = bookId;
            ci.BookUnitPrice = priceNew;
            ci.BookCount = count;
            ci.CustomerId = customerId;

            CartInfoBLL bll = new CartInfoBLL();
            if(bll.InsertCartInfo(ci))
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