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
    public class CartInfoDAL
    {
        /// <summary>
        /// get all cart table
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllCartInfo()
        {
            string sql = "select * from CartInfo";
            return SqlHelper.GetAllList(sql);
        }

        /// <summary>
        /// get all cartinfo by bookid
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public DataTable GetAllCartInfo(int customerId)
        {
            string sql = "select CId,BookId,BookCount,BookUnitPrice,Title,ImgTitle from CartInfo inner join BookInfo on CartInfo.BookId = BookInfo.Id where CustomerId=@CustomerId";
            SqlParameter ps = new SqlParameter("@CustomerId", customerId);
            return SqlHelper.GetAllList(sql,ps);
        }

        /// <summary>
        /// insert cart info
        /// </summary>
        /// <param name="ci"></param>
        /// <returns></returns>
        public int InsertCartInfo(CartInfo ci)
        {
            string sql = "insert into CartInfo (CustomerId,BookId,BookCount,BookUnitPrice) values(@CustomerId,@BookId,@BookCount,@BookUnitPrice)";
            SqlParameter[] ps = {
                                     new SqlParameter("@CustomerId",ci.CustomerId),
                                     new SqlParameter("@BookId",ci.BookId),
                                     new SqlParameter("@BookCount",ci.BookCount),
                                     new SqlParameter("@BookUnitPrice",ci.BookUnitPrice),
                                 };
            return SqlHelper.ExcuteNonQuery(sql, ps);
        }

        /// <summary>
        /// delete cart by Id
        /// </summary>
        /// <param name="cartId"></param>
        /// <returns></returns>
        public int DeleteCartInfoById(int cartId)
        {
            string sql = "delete from CartInfo where CId=@CId";
            SqlParameter ps = new SqlParameter("@CId",cartId);
            return SqlHelper.ExcuteNonQuery(sql, ps);
        }
    }
}
