using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Common
{
    public class SessionValidate
    {
        public static bool IsLogin()
        {
            if(HttpContext.Current.Session["id"] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}