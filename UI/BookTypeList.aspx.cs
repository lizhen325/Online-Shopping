using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookShopBLL;
using Model;
using System.Data;
using UI.Common;
using System.Web.Script.Serialization;

namespace UI
{
    public partial class BookTypeList : System.Web.UI.Page
    {
        public string ZTree { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            BookTypeBLL bll = new BookTypeBLL();
            DataTable dt = bll.GetAllBookType();
            List<BookTypeTree> list = new List<BookTypeTree>();
            if(dt.Rows.Count>0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new BookTypeTree()
                    {
                        id= Convert.ToInt32(dr["TypeId"]),
                        name = dr["TypeTitle"].ToString(),
                        pId = Convert.ToInt32(dr["TypeParentId"]),
                        open = true,
                        IsParent = true,
                        Click = "Prompt(" + Convert.ToInt32(dr["TypeId"]) + ")"
                    });
                }

            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            ZTree = js.Serialize(list);
        }
    }
}