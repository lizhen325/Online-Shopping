﻿using System;
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
    }
}
