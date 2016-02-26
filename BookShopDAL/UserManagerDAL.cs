using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BookShopDAL
{
    public class UserManagerDAL
    {
        /// <summary>
        /// Get all table
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public DataTable GetAllUser()
        {
            string sql = "select * from UserManager";
            DataTable dt = SqlHelper.GetAllList(sql);
            return dt;
        }
    }
}
