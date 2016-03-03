using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BookShopDAL
{
    public class CommentDAL
    {
        /// <summary>
        /// get comment by bookid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetCommentListByBookId(int id)
        {
            string sql = "select * from Comment where BookId=@BookId";
            SqlParameter[] ps = {
                                    new SqlParameter("@BookId",id)
                                 };
            return SqlHelper.GetAllList(sql, ps);
        }

        /// <summary>
        /// insert comment list
        /// </summary>
        /// <param name="ci"></param>
        /// <returns></returns>
        public int InsertCommentList(CommentInfo ci)
        {
            string sql = "insert into Comment (CommentMsg,CommentTime,BookId) values(@CommentMsg,@CommentTime,@BookId)";
            SqlParameter[] ps = {
                                     new SqlParameter("@CommentMsg",ci.CoomentMsg),
                                     new SqlParameter("@CommentTime",ci.CommentTime),
                                     new SqlParameter("@BookId",ci.BookId)
                                 };
            return SqlHelper.ExcuteNonQuery(sql, ps);
        }
    }
}
