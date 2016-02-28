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
        /// Get all list with where condition
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetList(string strWhere)
        {
            string sql = "select * from BookType where " + strWhere;
            return SqlHelper.GetAllList(sql);
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

        /// <summary>
        /// Delete book type by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteBookType(int id)
        {
            string sql = "delete from BookType where TypeId=@TypeId";
            return SqlHelper.ExcuteNonQuery(sql, new SqlParameter("@TypeId", id));
        }

        /// <summary>
        /// Get book type by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BookType GetBookTypeById(int id)
        {
            BookType bk = new BookType();
            string sql = "select * from BookType where TypeId=@TypeId";
            DataTable dt = SqlHelper.GetAllList(sql, new SqlParameter("@TypeId", id));
            if (dt.Rows.Count > 0)
            {
                bk = RowToBookType(dt.Rows[0]);
            }
            return bk;
        }

        private BookType RowToBookType(DataRow dr)
        {
            BookType bk = new BookType();
            bk.TypeId = Convert.ToInt32(dr["TypeId"]);
            bk.TypeTitle = dr["TypeTitle"].ToString();
            bk.TypeParentId = Convert.ToInt32(dr["TypeParentId"]);
            return bk;
        }

        /// <summary>
        /// updqte Book type by id
        /// </summary>
        /// <param name="bk"></param>
        /// <returns></returns>
        public int UpdateBookType(BookType bt)
        {
            string sql = "update BookType set TypeTitle=@TypeTitle,TypeParentId=@TypeParentId where TypeId=@TypeId";
            SqlParameter[] ps = {
                                    new SqlParameter("@TypeTitle",bt.TypeTitle),
                                    new SqlParameter("@TypeParentId",bt.TypeParentId),
                                    new SqlParameter("@TypeId",bt.TypeId)
                                };
            return SqlHelper.ExcuteNonQuery(sql, ps);
        }
    }
}
