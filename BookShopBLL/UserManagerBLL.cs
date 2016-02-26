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
        /// Get User Manager Info By Name
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public UserManager GetUserManagerByUserName(string userName)
        {
            return dal.GetUserManagerByUserName(userName);
        }
    }
}
