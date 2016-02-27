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
    public partial class BookTypeEdit : System.Web.UI.Page
    {
        public BookType BtModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            BookTypeBLL bll = new BookTypeBLL();
            BookType bt = new BookType();
            if (!IsPostBack)
            {
                int id = int.Parse(Request["pid"]);
                BtModel = bll.GetBookTypeById(id);
            }
            else
            {
                BtModel = new BookType();
                BtModel.TypeId = int.Parse(Request["tid"]);
                BtModel.TypeTitle = Request["title"];
                BtModel.TypeParentId = int.Parse(Request["tpid"]);
                if (bll.UpdateBookType(BtModel))
                {
                    Response.Redirect("../BookTypeList.aspx");
                }
                else
                {
                    Response.Redirect("Error.html");
                }
            }

        }
    }
}