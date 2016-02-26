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
    public class UserManagerDAL
    {
        /// <summary>
        /// Get all table
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public DataTable GetAllUser()
        {
            string sql = "select * from UserManager";
            DataTable dt = SqlHelper.GetAllList(sql);
            return dt;
        }

        /// <summary>
        /// Insert one user information
        /// </summary>
        /// <returns></returns>
        public int InsertUser(UserManager um)
        {
            string sql = "insert into UserManager(UserName,UserPwd)values(@UserName,@UserPwd)";
            SqlParameter [] ps = {
                                     new SqlParameter("@UserName",um.UserName),
                                     new SqlParameter("@UserPwd",um.UserPwd)
                                 };
            return SqlHelper.ExcuteNonQuery(sql, ps);
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
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from (");
            sb.Append("select row_number() over(");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                sb.Append("order by T." + orderby);
            }
            else
            {
                sb.Append("order by T.UserId desc");
            }
            sb.Append(") as row, T.* from UserManager T");
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
            sb.Append("select count(*) from UserManager");
            if(strWhere.Trim() != "")
            {
                sb.Append(" where" + strWhere);
            }
            object obj = SqlHelper.ExcuteScalar(sb.ToString());
            if(obj == null)
            {
                return 0;
            }
            return Convert.ToInt32(obj);
        }
    }
}
