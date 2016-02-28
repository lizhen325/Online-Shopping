using System;
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
                                     new SqlParameter("@Title",SqlDbType.VarChar,50),
                                     new SqlParameter("@SubTitle",SqlDbType.VarChar,50),
                                     new SqlParameter("@PriceOld",SqlDbType.Decimal,5),
                                     new SqlParameter("@PriceNew",SqlDbType.Decimal,5),
                                     new SqlParameter("@Author",SqlDbType.VarChar,50),
                                     new SqlParameter("@Publisher",SqlDbType.VarChar,50),
                                     new SqlParameter("@PublishDate",SqlDbType.VarChar,50),
                                     new SqlParameter("@SaleDate",SqlDbType.VarChar,50),
                                     new SqlParameter("@ISBN",SqlDbType.VarChar,50),
                                     new SqlParameter("@TypeId",SqlDbType.VarChar,50),
                                     new SqlParameter("@Details",SqlDbType.VarChar,-1),
                                     new SqlParameter("@ImgTitle",SqlDbType.VarChar,50)
                                 };
            ps[0].Value = bi.BookTitle;
            ps[1].Value = bi.SubTitle;
            ps[2].Value = bi.PriceOld;
            ps[3].Value = bi.PriceNew;
            ps[4].Value = bi.Author;
            ps[5].Value = bi.Publisher;
            ps[6].Value = bi.PublishDate;
            ps[7].Value = bi.SaleDate;
            ps[8].Value = bi.Isbn;
            ps[9].Value = bi.TypeId;
            ps[10].Value = bi.Details;
            ps[11].Value = bi.ImgTitle;

            return SqlHelper.ExcuteNonQuery(sql, ps);
        }

        /// <summary>
        /// delete book info by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteBookInfoById(int id)
        {
            string sql = "delete from BookInfo where Id=@Id ";
            return SqlHelper.ExcuteNonQuery(sql, new SqlParameter("@Id", id));
        }
    }
}
