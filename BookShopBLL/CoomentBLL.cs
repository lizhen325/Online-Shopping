﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using BookShopDAL;
using System.Data;

namespace BookShopBLL
{
    public class CoomentBLL
    {
        BookShopDAL.CommentDAL dal = new CommentDAL();
        /// <summary>
        /// get comment by bookid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetCommentListByBookId(int id)
        {
            return dal.GetCommentListByBookId(id);
        }
    }
}
