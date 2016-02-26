using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BookShopBLL;

namespace UI.Admin
{
    public partial class UserManagerAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserManager um = new UserManager();
            um.UserName = Request["txtName"];
            um.UserPwd = Request["txtPwd"];
            UserManagerBLL bll = new UserManagerBLL();
            int i = bll.InsertUser(um);
            if(i > 0)
            {
                Context.Response.Write("ok");
            }
            else
            {
                Context.Response.Write("no");
            }
        }
    }
}