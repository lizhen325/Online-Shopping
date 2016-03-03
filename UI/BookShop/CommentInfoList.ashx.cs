using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using BookShopBLL;
using System.Data;
using System.Web.Script.Serialization;

namespace UI.BookShop
{
    /// <summary>
    /// Summary description for CommentInfoList
    /// </summary>
    public class CommentInfoList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["id"]);
            BookShopBLL.CoomentBLL bll = new CoomentBLL();
            DataTable dt = bll.GetCommentListByBookId(id);
            List<CommentShowModel> list = new List<CommentShowModel>();
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new CommentShowModel()
                {
                    CTime = dr["CommentTime"].ToString("yyyy-MM--dd"),
                    CMsg = dr["CommentMsg"].ToString()
                });
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            string result = js.Serialize(list);
            context.Response.Write(result);


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