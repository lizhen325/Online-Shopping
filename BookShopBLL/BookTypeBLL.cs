using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDAL;
using System.Data;
using System.Data.SqlClient;

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
    }
}
