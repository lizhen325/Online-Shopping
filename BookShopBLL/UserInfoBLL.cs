﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDAL;
using System.Data;
using Model;

namespace BookShopBLL
{
    public class UserInfoBLL
    {
        UserInfoDAL dal = new UserInfoDAL();

        /// <summary>
        /// Get All UserInformation
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllUserInfo()
        {
            return dal.GetAllUserInfo();
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

        /// <summary>
        /// Insert UserInfo
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public bool InsertUserInfo(UserInfo ui)
        {
            return dal.InsertUserInfo(ui) > 0;
        }

        /// <summary>
        /// Remove UserInfo by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool RemoveUserInfoById(int id)
        {
            return dal.RemoveUserInfoById(id) > 0;
        }

        /// <summary>
        /// Get user information by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoById(int id)
        {
            return dal.GetUserInfoById(id);
        }

         /// <summary>
        /// Update UserInfo by Id
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public bool UpdateUserInfoById(UserInfo ui)
        {
            return dal.UpdateUserInfoById(ui) > 0;
        }

        /// <summary>
        /// get user info by user name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoByUserName(string name)
        {
            return dal.GetUserInfoByUserName(name);
        }

        /// <summary>
        /// Get userinfo by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoByEmail(string email)
        {
            return dal.GetUserInfoByEmail(email);
        }

        /// <summary>
        /// get user info by username and userpassword
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoByUserNameAndUserPassword(string username,string password)
        {
            return dal.GetUserInfoByUserNameAndUserPassword(username, password);
        }

         /// <summary>
        /// update userinfo by username
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public bool UpdateUserInfoByUerName(UserInfo ui)
        {
            return dal.UpdateUserInfoByUerName(ui) > 0;
        }

         /// <summary>
        /// insert userinfo registered by facebook
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public bool InsertUserInfoByFaceBook(UserInfo ui)
        {
            return dal.InsertUserInfoByFaceBook(ui) > 0;
        }

        /// <summary>
        /// get userinfo by Username and email for backup password
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public UserInfo ForGetPassword(string id, string email)
        {
            return dal.ForGetPassword(id, email);
        }

        /// <summary>
        /// update password by user name
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public bool UpdatePassword(UserInfo ui)
        {
            return dal.UpdatePassword(ui) > 0;
        }
    }
}
