using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BookShopDAL
{
    public class BookInfoDAL
    {
        /// <summary>
        /// get all book info
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllBookInfo()
        {
            string sql = "select * from BookInfo";
            DataTable dt = SqlHelper.GetAllList(sql);
            return dt;
        }
    }
}
