﻿using System;
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

        [TestMethod()]
        public void InsertBookType(BookType bt)
        {
            bt.TypeTitle = "Programming";
            bt.TypeParentId = 3;
            int i = dal.InsertBookType(bt);
            Assert.IsTrue(i > 0);
        }

        [TestMethod()]
        public void UpdateBookType()
        {
            BookType bt = new BookType();
            bt.TypeId = 1;
            bt.TypeTitle = "Programming";
            bt.TypeParentId = 3;
            int i = dal.UpdateBookType(bt);
            Assert.IsTrue(i > 0);
        }

        [TestMethod()]
        public void GetList()
        {
            string strWhere = " TypeParentId=0";
            DataTable dt = dal.GetList(strWhere);
            Assert.IsNotNull(dt);
        }
    }
}
