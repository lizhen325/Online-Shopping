using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.SqlClient;
using Model;
using BookShopDAL;

namespace UI.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestInsert()
        {
            UserManager um = new UserManager();
            UserManagerDAL dal = new UserManagerDAL();
            um.UserName = "lizhen";
            um.UserPwd = "1111";
            string sql = "insert into UserManager (UserName,UserPwd) values(@UserName,@UserPwd)";
            SqlParameter[] ps = {
                                     new SqlParameter("@UserName",um.UserName),
                                     new SqlParameter("@UserPwd",um.UserPwd)
                                 };
            int i2 = SqlHelper.ExcuteNonQuery(sql, ps);
            //int i = dal.InsertUser(um);
            Assert.IsTrue(i2 > 0);
            
        }
    }
}
