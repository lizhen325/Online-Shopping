using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BookShopDAL
{
    public class BookTypeDAL
    {
        /// <summary>
        /// Get All BookType
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllBookType()
        {
            string sql = "select * from BookType";
            DataTable dt = SqlHelper.GetAllList(sql);
            return dt;
        }
    }
}
