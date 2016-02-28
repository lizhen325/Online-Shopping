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
        BookInfo bi = new BookInfo();
        [TestMethod]
        public void GetAllBookInfo()
        {
            DataTable dt = dal.GetAllBookInfo();
            Assert.IsNotNull(dt);
        }

        [TestMethod()]
        public void InsertBookInfo()
        {
            bi.BookTitle = "C#";
            bi.SubTitle = ".Net Framework";
            bi.PriceOld = 45m;
            bi.PriceNew = 30m;
            bi.Author = "Jin";
            bi.Publisher = "Massey University";
            bi.PublishDate = Convert.ToDateTime("2016-02-29");
            bi.SaleDate = System.DateTime.Now;
            bi.Isbn = "123456789";
            bi.TypeId = "1";
            bi.Details = "C# is a good computer Language";
            bi.ImgTitle = "http://www.google.co.nz/img/aaa";
            int i = dal.InsertBookInfo(bi);
            Assert.IsTrue(i > 0);
        }
    }
}
