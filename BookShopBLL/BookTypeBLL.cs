using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDAL;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace BookShopBLL
{
    public class BookTypeBLL
    {
        BookTypeDAL dal = new BookTypeDAL();
        /// <summary>
        /// Get All BookType
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllBookType()
        {
            return dal.GetAllBookType();
        }

        /// <summary>
        /// Insert book type
        /// </summary>
        /// <param name="bt"></param>
        /// <returns></returns>
        public bool InsertBookType(BookType bt)
        {
            return dal.InsertBookType(bt) > 0;
        }
    }
}
