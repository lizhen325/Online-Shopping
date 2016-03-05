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
            string sql = "insert into UserInfo (UserName,UserPwd,Email,Address,MobilePhone,RegisterTime,State) values(@UserName,@UserPwd,@Email,@Address,@MobilePhone,@RegisterTime,@State)";
            SqlParameter[] ps = {
                                     new SqlParameter("@UserName",ui.UserName),
                                     new SqlParameter("@UserPwd",ui.UserPwd),
                                     new SqlParameter("@Email",ui.Email),
                                     new SqlParameter("@Address",ui.Address),
                                     new SqlParameter("@MobilePhone",ui.MobilePhone),
                                     new SqlParameter("@RegisterTime",ui.RegisterTime),
                                     new SqlParameter("@State",ui.State)
                                 };
            return SqlHelper.ExcuteNonQuery(sql, ps);
        }

        /// <summary>
        /// insert userinfo registered by facebook
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public int InsertUserInfoByFaceBook(UserInfo ui)
        {
            string sql = "insert into UserInfo(UserName,UserPwd,Email,RegisterTime,State) values(@UserName,@UserPwd,@Email,@RegisterTime,@State)";
            SqlParameter[] ps = {
                                    new SqlParameter("@UserName",ui.UserName),
                                    new SqlParameter("@UserPwd",ui.UserName),
                                    new SqlParameter("@Email",ui.Email),
                                    new SqlParameter("@RegisterTime",ui.RegisterTime),
                                    new SqlParameter("@State",ui.State)
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

        /// <summary>
        /// Get user information by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoById(int id)
        {
            UserInfo ui = new UserInfo();
            string sql = "select * from UserInfo where UserId=@UserId";
            DataTable dt = SqlHelper.GetAllList(sql, new SqlParameter("@UserId",id));
            if (dt.Rows.Count > 0)
            {
                ui = RowToUserInfo(dt.Rows[0]);
            }
            return ui;
        }

        private UserInfo RowToUserInfo(DataRow dr)
        {
            UserInfo ui = new UserInfo();
            ui.UserId = Convert.ToInt32(dr["UserId"]);
            ui.UserName = dr["UserName"].ToString();
            //ui.UserPwd = dr["UserPwd"].ToString();
            ui.Email = dr["Email"].ToString();
            ui.Address = dr["Address"].ToString();
            ui.MobilePhone = dr["MobilePhone"].ToString();
            //ui.RegisterTime = Convert.ToDateTime(dr["RegisterTime"]);
            //ui.LoginTime = Convert.ToDateTime(dr["LoginTime"]);
            ui.State = Convert.ToInt32(dr["State"]);
            return ui;
        }

        /// <summary>
        /// Update UserInfo by Id
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public int UpdateUserInfoById(UserInfo ui)
        {
            string sql = "update UserInfo set UserName=@UserName,Email=@Email,Address=@Address,MobilePhone=@MobilePhone where UserId=@UserId";
            SqlParameter[] ps = {
                                     new SqlParameter("@UserName",ui.UserName),
                                     new SqlParameter("@Email",ui.Email),
                                     new SqlParameter("@Address",ui.Address),
                                     new SqlParameter("@MobilePhone",ui.MobilePhone),
                                     new SqlParameter("@UserId",ui.UserId)
                                 };
            return SqlHelper.ExcuteNonQuery(sql, ps);
        }

        /// <summary>
        /// get user info by user name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoByUserName(string name)
        {
            string sql = "select * from UserInfo where UserName=@UserName";
            UserInfo ui = null;
            DataTable dt = SqlHelper.GetAllList(sql, new SqlParameter("@UserName", name));
            if(dt.Rows.Count > 0)
            {
                ui = RowToUserInfo(dt.Rows[0]);
            }
            return ui;
        }

        /// <summary>
        /// Get userinfo by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoByEmail(string email)
        {
            string sql = "select * from UserInfo where Email=@Email";
            DataTable dt = SqlHelper.GetAllList(sql, new SqlParameter("@Email", email));
            UserInfo ui = null;
            if(dt.Rows.Count > 0)
            {
                ui = RowToUserInfo(dt.Rows[0]);
            }
            return ui;
        }

        /// <summary>
        /// get user info by username and userpassword
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoByUserNameAndUserPassword(string username,string password)
        {
            string sql = "select * from UserInfo where UserName=@UserName and UserPwd=@UserPwd";
            SqlParameter [] ps = {
                                     new SqlParameter("@UserName",username),
                                     new SqlParameter("@UserPwd",password)
                                 };
            DataTable dt = SqlHelper.GetAllList(sql, ps);
            UserInfo ui = null;
            if(dt.Rows.Count > 0)
            {
                ui = RowToUserInfo(dt.Rows[0]);
            }
            return ui;
        }

        /// <summary>
        /// update userinfo by username
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public int UpdateUserInfoByUerName(UserInfo ui)
        {
            string sql = "update UserInfo set State=@State where UserName=@UserName";
            SqlParameter [] ps = {
                                     new SqlParameter("@State",ui.State),
                                     new SqlParameter("@UserName",ui.UserName)
                                 };
            return SqlHelper.ExcuteNonQuery(sql, ps);
        }
    }
}
