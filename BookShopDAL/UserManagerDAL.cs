using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace BookShopDAL
{
    public class UserManagerDAL
    {
        /// <summary>
        /// Get User Manager Info By Name
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public UserManager GetUserManagerByUserName(string userName)
        {
            string sql = "select * from UserManager where UserName=@Username";
            DataTable dt = SqlHelper.GetAllList(sql,new SqlParameter("@UserName",userName));
            UserManager um = null;
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    um = RowToUserManagerInfo(dr);
                }
            }
            return um;
        }

        private UserManager RowToUserManagerInfo(DataRow dr)
        {
            UserManager um = new UserManager();
            um.UserId = Convert.ToInt32(dr["Id"]);
            um.UserName = dr["UserName"].ToString();
            um.UserPwd = dr["UserPwd"].ToString();
            return um;
        }
    }
}
