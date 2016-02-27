using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookShopDAL;
using Model;
using System.Data;

namespace UI.Tests
{
    [TestClass]
    public class BookInfoDALTest
    {
        BookInfoDAL dal = new BookInfoDAL();
        [TestMethod]
        public void GetAllBookInfo()
        {
            DataTable dt = dal.GetAllBookInfo();
            Assert.IsNotNull(dt);
        }
    }
}
