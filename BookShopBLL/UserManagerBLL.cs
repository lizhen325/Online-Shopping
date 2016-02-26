﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BookShopDAL;

namespace BookShopBLL
{
    public class UserManagerBLL
    {
        UserManagerDAL dal = new UserManagerDAL();
        /// <summary>
        /// Get all table
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public DataTable GetAllUser()
        {
            return dal.GetAllUser();
        }
    }
}
