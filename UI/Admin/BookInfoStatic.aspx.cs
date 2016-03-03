using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookShopBLL;
using Model;
using System.Data;

namespace UI.Admin
{
    public partial class BookInfoStatic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                int start = Convert.ToInt32(Request["startId"]);
                int end = Convert.ToInt32(Request["endId"]);
                //absolute path
                string path = Request.MapPath("/");
                string temp = File.ReadAllText(Request.MapPath("/BookDetail.html"));
                BookInfoBLL bll = new BookInfoBLL();
                for (int i = start; i < end; i++)
                {
                    Model.BookInfo bi = bll.GetBookInfoById(i);
                    //if id is not exist.
                    if(bi == null)
                    {
                        continue;
                    }
                    //each folder can contain 500 html page, file name is id
                    string path2 = path + (i / 500);
                    if(!Directory.Exists(path2))
                    {
                        Directory.CreateDirectory(path2);
                    }
                    string path3 = Path.Combine(path2, bi.Id + ".html");
                    //replace all text
                    string temp2 = temp.Replace("$imgTitle", bi.ImgTitle)
                                .Replace("$Details", bi.Details)
                                .Replace("$BookTitle", bi.BookTitle)
                                .Replace("$SubTitle", bi.SubTitle)
                                .Replace("$Author", bi.Author)
                                .Replace("$price", bi.PriceOld.ToString())
                                .Replace("$old", bi.PriceNew.ToString())
                                .Replace("$Isbn", bi.Isbn)
                                .Replace("$Publisher", bi.Publisher)
                                .Replace("$PublishDate", bi.PublishDate.ToString("yyyy-MM-dd"))
                                .Replace("$id", bi.Id.ToString());
                    File.WriteAllText(path3, temp2);
                }
                Response.Write("<b style='color:red;'>Success to Generate</b>");
            
            }
            else
            {
                BookInfoBLL bll = new BookInfoBLL();
                Model.BookInfo bi = new Model.BookInfo();
                DataTable dt = bll.GetAllBookInfo();
                int max = 1;
                int start = 2;
                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        bi = RowToGetBookInfo(dr);
                        if((bi.Id + 1 - bi.Id) == 1)
                        {
                            max++;
                            continue;      
                        }
                    }
                }
                //Get Id domain
                Context.Response.Write("Id domain:" + start + "--" + max);
            }
        }

        private Model.BookInfo RowToGetBookInfo(DataRow dr)
        {
            Model.BookInfo bi = new Model.BookInfo();
            bi.Id = Convert.ToInt32(dr["Id"]);
            return bi;
            
        }
    }
}