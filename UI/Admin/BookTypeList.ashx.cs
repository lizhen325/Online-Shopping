using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShopBLL;
using System.Data;
using Model;
using System.Web.Script.Serialization;

namespace UI.Admin
{
    /// <summary>
    /// Summary description for BookTypeList
    /// </summary>
    public class BookTypeList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int type = int.Parse(context.Request["type"]);
            int pid = int.Parse(context.Request["pid"]);
            string strWhere = " TypeParentId=";
            if(type == 1)
            {
                strWhere += "0 ";
            }
            else
            {
                strWhere += pid + " ";
            }
            BookTypeBLL bll = new BookTypeBLL();
            DataTable dt = bll.GetList(strWhere);
            List<BookType> list = new List<BookType>();
           
                foreach(DataRow dr in dt.Rows)
                {
                    list.Add(new BookType()
                    {
                        TypeId = Convert.ToInt32(dr["TypeId"]),
                        TypeTitle = dr["TypeTitle"].ToString()
                    });
                }
            
            JavaScriptSerializer js = new JavaScriptSerializer();
            string temp = js.Serialize(list);
            context.Response.Write(temp);
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