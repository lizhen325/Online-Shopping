using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BookShopDAL;
using Model;

namespace BookShopBLL
{
    public class UserManagerBLL
    {
        UserManagerDAL dal = new UserManagerDAL();
        /// <summary>
        /// Get all table
        /// </summary>
        public DataTable GetAllUser()
        {
            return dal.GetAllUser();
        }

        public int InsertUser(UserManager um)
        {
            return dal.InsertUser(um);
        }

        /// <summary>
        /// Get table information by page
        /// </summary>
        /// <param name="strwhere">where </param>
        /// <param name="orderby">order by</param>
        /// <param name="pageIndex">start index</param>
        /// <param name="pageSize">end index</param>
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
    }
}
