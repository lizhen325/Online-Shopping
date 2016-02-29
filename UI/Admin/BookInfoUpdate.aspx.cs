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
    public partial class BookInfoUpdate : System.Web.UI.Page
    {
        protected Model.BookInfo biModel { get; set; }
        BookInfoBLL bll = new BookInfoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Model.BookInfo bi = new Model.BookInfo();
                int id = int.Parse(Request["id"]);
                biModel = bll.GetBookInfoById(id);
            }
            else
            {
                Model.BookInfo bi = new Model.BookInfo();
                bi.BookTitle = Request["title"];
                bi.SubTitle = Request["subtitle"];
                bi.PriceOld = Convert.ToDecimal(Request["price"]);
                bi.PriceNew = Convert.ToDecimal(Request["discountprice"]);
                bi.Author = Request["author"];
                bi.Publisher = Request["publisher"];
                bi.PublishDate = Convert.ToDateTime(Request["publishdate"]);
                bi.Isbn = Request["isbn"];
                bi.TypeId = Request["type1"] + "," + Request["type2"] + "," + Request["type3"];
                bi.Details = Request["editorValue"];
                bi.Id = Convert.ToInt32(Request["bid"]);
                bi.ImgTitle = Request["imgTitle"];
                if (bll.InsertBookInfo(bi))
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