using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
namespace UserManagerInfoDALTest
{
    [TestClass()]
    public class TestUserManagerDAL
    {
        [TestMethod()]
        public void GetUserManagerByUserName()
        {
            UserManagerDAL dal = new UserManagerDAL();
            UserManager um1 = new UserManager();
            um1.UserId = 1;
            um1.UserName = "admin";
            um1.UserPwd = "admin";
            UserManager um2 = dal.GetUserManagerByUserName("admin");
            Assert.IsNotNull(um2);
        }
    }
}
