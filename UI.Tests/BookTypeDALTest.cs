using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookShopDAL;
using Model;
using System.Data;

namespace UI.Tests
{
    /// <summary>
    /// Summary description for BookTypeDAL
    /// </summary>
    [TestClass]
    public class BookTypeDALTest
    {
        BookShopDAL.BookTypeDAL dal = new BookTypeDAL();
        [TestMethod()]
        public void UpdateUserInfoById()
        {
            DataTable dt = dal.GetAllBookType();
            Assert.IsNotNull(dt);
        }
    }
}
