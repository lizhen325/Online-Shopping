using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using BookShopDAL;

namespace UI.Tests
{
    [TestClass]
    public class CoomentInfoDAL
    {
        CommentDAL dal = new CommentDAL();
        CommentInfo ci = new CommentInfo();
        [TestMethod]
        public void InsertCommentList()
        {
            ci.BookId = 2;
            ci.CommentTime = DateTime.Now;
            ci.CoomentMsg = "Hello";
            int i = dal.InsertCommentList(ci);
            Assert.IsTrue(i > 0);
        }
    }
}
