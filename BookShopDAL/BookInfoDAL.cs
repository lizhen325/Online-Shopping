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

        /// <summary>
        /// get book info by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BookInfo GetBookInfoById(int id)
        {
            BookInfo bi = new BookInfo();
            string sql = "select * from BookInfo where Id=@Id";
            DataTable dt = SqlHelper.GetAllList(sql, new SqlParameter("@Id", id));
            if(dt.Rows.Count > 0)
            {
                bi = RowToBookInfo(dt.Rows[0]);
            }
            return bi;
        }

        private BookInfo RowToBookInfo(DataRow row)
        {
            BookInfo bi = new BookInfo();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    bi.Id = int.Parse(row["Id"].ToString());
                }
                if (row["Title"] != null)
                {
                    bi.BookTitle = row["Title"].ToString();
                }
                if (row["SubTitle"] != null)
                {
                    bi.SubTitle = row["SubTitle"].ToString();
                }
                if (row["PriceOld"] != null && row["PriceOld"].ToString() != "")
                {
                    bi.PriceOld = decimal.Parse(row["PriceOld"].ToString());
                }
                if (row["PriceNew"] != null && row["PriceNew"].ToString() != "")
                {
                    bi.PriceNew = decimal.Parse(row["PriceNew"].ToString());
                }
                if (row["Author"] != null)
                {
                    bi.Author = row["Author"].ToString();
                }
                if (row["Publisher"] != null)
                {
                    bi.Publisher = row["Publisher"].ToString();
                }
                if (row["PublishDate"] != null && row["PublishDate"].ToString() != "")
                {
                    bi.PublishDate = DateTime.Parse(row["PublishDate"].ToString());
                }
                if (row["SaleDate"] != null && row["SaleDate"].ToString() != "")
                {
                    bi.SaleDate = DateTime.Parse(row["SaleDate"].ToString());
                }
                if (row["ISBN"] != null)
                {
                    bi.Isbn = row["ISBN"].ToString();
                }
                if (row["TypeId"] != null)
                {
                    bi.TypeId = row["TypeId"].ToString();
                }
                if (row["Details"] != null)
                {
                    bi.Details = row["Details"].ToString();
                }
                if (row["ImgTitle"] != null)
                {
                    bi.ImgTitle = row["ImgTitle"].ToString();
                }
            }
            return bi;
        }
        /// <summary>
        /// update book info by id
        /// </summary>
        /// <param name="bi"></param>
        /// <returns></returns>
        public int UpdateBookInfo(Model.BookInfo bi)
        {
            string sql = "update BookInfo set Title=@Title,SubTitle=@SubTitle,PriceOld=@PriceOld,PriceNew=@PriceNew,Author=@Author,Publisher=@Publisher,@PublishDate=@PublishDate,SaleDate=@SaleDate,ISBN=@ISBN,TypeId=@TypeId,Details=@Details,ImgTitle=@ImgTitle where Id=@Id";
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
                                    new SqlParameter("@ImgTitle",bi.ImgTitle),
                                    new SqlParameter("@Id",bi.Id)
                                };
            return SqlHelper.ExcuteNonQuery(sql, ps);
        }
    }
}
