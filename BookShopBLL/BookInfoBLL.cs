using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDAL;
using System.Data;

namespace BookShopBLL
{
    public class BookInfoBLL
    {
        BookInfoDAL dal = new BookInfoDAL();
        /// <summary>
        /// get all book info
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllBookInfo()
        {
            return dal.GetAllBookInfo();
        }
    }
}
