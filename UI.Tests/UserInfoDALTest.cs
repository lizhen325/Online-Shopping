﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDAL;
using Model;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookShopBLL;

namespace UserInfoDALTest.Tests
{
    [TestClass()]
    public class Test
    {
        private UserInfo ui = new UserInfo();
        private UserInfoDAL dal = new UserInfoDAL();
        [TestMethod()]
        public void InsertUserInfo()
        {
            ui.UserName = "Lizhen";
            ui.UserPwd = "flwls3250";
            ui.Email = "zhenli336@gmail.com";
            ui.Address = "Albany";
            ui.MobilePhone = "0211017759";
            ui.RegisterTime = System.DateTime.Now;
            int i = dal.InsertUserInfo(ui);
            Assert.IsTrue(i > 0);
        }

        [TestMethod()]
        public void GetRecordCount()
        {
            string strWhere = "";
            int i = dal.GetRecordCount(strWhere);
            Assert.IsTrue(i > 0);
        }

        [TestMethod()]
        public void GetListByPage()
        {
            string strWhere = "";
            string orderby = "UserId";
            int pageIndex = 1;
            int pageSize = 1;
            DataSet ds = dal.GetListByPage(strWhere, orderby, pageIndex, pageSize);
            Assert.IsNotNull(ds);
        }

        [TestMethod()]
        public void GetAllUserInfo()
        {
            DataTable dt = dal.GetAllUserInfo();
            Assert.IsNotNull(dt);
        }
    }
}