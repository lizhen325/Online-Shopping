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

        /// <summary>
        /// Insert book type
        /// </summary>
        /// <param name="bt"></param>
        /// <returns></returns>
        public int InsertBookType(BookType bt)
        {
            string sql = "insert into BookType (TypeTitle,TypeParentId) values(@TypeTitle,@TypeParentId)";
            SqlParameter[] ps = {
                                     new SqlParameter("@TypeTitle",bt.TypeTitle),
                                     new SqlParameter("@TypeParentId",bt.TypeParentId)
                                 };
            return SqlHelper.ExcuteNonQuery(sql, ps);
        }
    }
}
