﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Model;

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

        /// <summary>
        /// get userinfo by page
        /// </summary>
        /// <param name="strwhere"></param>
        /// <param name="orderby"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public DataSet GetListByPage(string strwhere, string orderby, int pageIndex, int pageSize)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from (");
            sb.Append("select row_number() over(");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                sb.Append("order by T." + orderby);
            }
            else
            {
                sb.Append("order by T.Id desc");
            }
            sb.Append(") as row, T.* from BookInfo T");
            if (!string.IsNullOrEmpty(strwhere.Trim()))
            {
                sb.Append(" where " + strwhere);
            }
            sb.Append(") TT");
            sb.AppendFormat(" where TT.row between {0} and {1}", pageIndex, pageSize);
            return SqlHelper.Query(sb.ToString());
        }

        /// <summary>
        /// Get All Information
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select count(*) from BookInfo");
            if (strWhere.Trim() != "")
            {
                sb.Append(" where" + strWhere);
            }
            object obj = SqlHelper.ExcuteScalar(sb.ToString());
            if (obj == null)
            {
                return 0;
            }
            return Convert.ToInt32(obj);
        }

        /// <summary>
        /// Insert book info
        /// </summary>
        /// <param name="bi"></param>
        /// <returns></returns>
        public int InsertBookInfo(BookInfo bi)
        {
            string sql = "insert into BookInfo (Title,SubTitle,PriceOld,PriceNew,Author,Publisher,PublishDate,SaleDate,ISBN,TypeId,Details,Imgtitle) values(@Title,@SubTitle,@PriceOld,@PriceNew,@Author,@Publisher,@PublishDate,@SaleDate,@ISBN,@TypeId,@Details,@Imgtitle) ";
            SqlParameter[] ps = {
                                     new SqlParameter("@Title",bi.BookTitle),
                                     new SqlParameter("@SubTitle",bi.SubTitle),
                                     new SqlParameter("@PriceOld",bi.PriceOld),
                                     new SqlParameter("@PriceNew",bi.PriceNew),
                                     new SqlParameter("@Author",bi.Author),
                                     new SqlParameter("@Publisher",bi.Publisher),
                                     new SqlParameter("@PublishDate",bi.PublishDate),
                                     new SqlParameter("@SaleDate",bi.SaleDate),
                                     new SqlParameter("@ISBN",bi.Isbn),
                                     new SqlParameter("@TypeId",bi.TypeId),
                                     new SqlParameter("@Details",bi.Details),
                                     new SqlParameter("@ImgTitle",bi.ImgTitle)
                                 };
            return SqlHelper.ExcuteNonQuery(sql, ps);
        }
    }
}
