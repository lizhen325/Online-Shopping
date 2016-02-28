using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookShopBLL;
using Model;

namespace UI.Admin
{
    public partial class BookInfoAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model.BookInfo bi = new Model.BookInfo();
            if(IsPostBack)
            {
                bi.BookTitle = Request["title"];
                bi.SubTitle = Request["subtitle"];
                bi.PriceNew = Convert.ToInt32(Request["price"]);
                bi.PriceOld = Convert.ToInt32(Request["discountprice"]);
                bi.Author = Request["author"];
                bi.Publisher = Request["publisher"];
                bi.PublishDate = Convert.ToDateTime(Request["publishdate"]);
                bi.SaleDate = System.DateTime.Now;
                bi.Isbn = Request["isbn"];
                bi.TypeId = Request["type1"] + "," + Request["type2"] + "," + Request["type3"];
                bi.ImgTitle = Request["imgTitle"];
                bi.Details = Request["editorValue"];

                BookShopBLL.BookInfoBLL bll = new BookInfoBLL();
                if(bll.InsertBookInfo(bi))
                {
                    Response.Redirect("BookInfo.aspx");
                }
                else
                {
                    Response.Redirect("Error.html");
                }
            }
        }
    }
}