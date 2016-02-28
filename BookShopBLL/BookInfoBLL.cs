using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDAL;
using System.Data;
using Model;

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
            return dal.GetListByPage(strwhere, orderby, pageIndex, pageSize);
        }

        /// <summary>
        /// Get All Information
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

        /// <summary>
        /// Insert book info
        /// </summary>
        /// <param name="bi"></param>
        /// <returns></returns>
        public bool InsertBookInfo(BookInfo bi)
        {
            return dal.InsertBookInfo(bi) > 0;
        }
    }
}
