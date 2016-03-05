using System;
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

        [TestMethod()]
        public void RemoveUserInfoById()
        {
            int i = dal.RemoveUserInfoById(10);
            Assert.AreEqual(1,i);
        }

        [TestMethod()]
        public void GetUserInfoById()
        {
            UserInfo ui2 = new UserInfo();
            ui2 = dal.GetUserInfoById(2);
            Assert.IsNotNull(ui2);
        }

        [TestMethod()]
        public void UpdateUserInfoById()
        {
            ui.UserId = 2;
            ui.UserName = "Jin";
            ui.Email = "lizhen_325@hotmail.com";
            ui.MobilePhone = "1234567";
            ui.Address = "New Zealand";
            int i = dal.UpdateUserInfoById(ui);
            Assert.IsTrue(i > 0);
        }
        
        [TestMethod()]
        public void GetUserInfoByUserName()
        {
            string name = "aaaa";
            UserInfo ui = dal.GetUserInfoByUserName(name);
            Assert.IsNull(ui);
        }

        [TestMethod()]
        public void GetUserInfoByUserNameAndUserPassword()
        {
            string username = "Jin";
            string password = "lizhen";
            UserInfo ui = dal.GetUserInfoByUserNameAndUserPassword(username, password);
            Assert.IsNotNull(ui);
        }

        [TestMethod()]
        public void UpdateUserInfoByUerName()
        {
            UserInfo ui = new UserInfo();
            ui.State = 1;
            ui.UserName = "lizhen3030";
            int i = dal.UpdateUserInfoByUerName(ui);
            Assert.IsTrue(i > 0);
        }
    }
}
