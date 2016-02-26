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
    public class UserInfoDAL
    {
        /// <summary>
        /// Get All UserInformation
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllUserInfo()
        {
            string sql = "select * from UserInfo";
            DataTable dt = SqlHelper.GetAllList(sql);
            return dt;
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
            sb.Append(") as row, T.* from UserInfo T");
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
            sb.Append("select count(*) from UserInfo");
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
        /// Insert UserInfo
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public int InsertUserInfo(UserInfo ui)
        {
            string sql = "insert into UserInfo (UserName,UserPwd,Email,Address,MobilePhone,RegisterTime) values(@UserName,@UserPwd,@Email,@Address,@MobilePhone,@RegisterTime)";
            SqlParameter[] ps = {
                                     new SqlParameter("@UserName",ui.UserName),
                                     new SqlParameter("@UserPwd",ui.UserPwd),
                                     new SqlParameter("@Email",ui.Email),
                                     new SqlParameter("@Address",ui.Address),
                                     new SqlParameter("@MobilePhone",ui.MobilePhone),
                                     new SqlParameter("@RegisterTime",ui.RegisterTime)
                                 };
            return SqlHelper.ExcuteNonQuery(sql, ps);
        }

        /// <summary>
        /// Remove UserInfo by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int RemoveUserInfoById(int id)
        {
            string sql = "delete from UserInfo where UserId=@UserId";
            return SqlHelper.ExcuteNonQuery(sql, new SqlParameter("@UserId", id));
        }
    }
}
