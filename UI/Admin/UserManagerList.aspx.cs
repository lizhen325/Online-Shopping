using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace UI.Admin
{
    public partial class UserManagerList : System.Web.UI.Page
    {
        protected string PageBar { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int pageIndex = 1;
            int pageSize = 1;
            if(!string.IsNullOrEmpty(Request["pIndex"]))
            {
                pageIndex = Convert.ToInt32(Request["pIndex"]);
            }
            BookShopBLL.UserManagerBLL umb = new BookShopBLL.UserManagerBLL();
            int startIndex = (pageIndex-1) * pageSize + 1;
            int endIndex = pageIndex * pageSize;
            Repeater1.DataSource = umb.GetListByPage("", "UserId", startIndex, endIndex);
            Repeater1.DataBind();

            //Get counts of table
            int rowsCount = umb.GetRecordCount("");
            StringBuilder sb = new StringBuilder();
            //First Page, Previous Page
            if(pageIndex <= 1)
            {
                sb.Append("<< Prev");
            }
            else
            {
                sb.Append("<a href='?pIndex=1'> << </a> <a href='?pIndex=" + (pageIndex - 1) + "'> Prev </a>");
            }
            
            //page count
            int pageCount = Convert.ToInt32(Math.Ceiling(rowsCount*1.0 / pageSize));
            //Next Page, Last Page
            if(pageIndex >= pageCount)
            {
                sb.Append("Next >>");
            }
            else
            {
                sb.Append("<a href='?pIndex=" + (pageIndex + 1) + "'> Next </a> <a href='?pIndex="+pageCount+"'> >>" );
            }

            PageBar = sb.ToString();
        }
    }
}