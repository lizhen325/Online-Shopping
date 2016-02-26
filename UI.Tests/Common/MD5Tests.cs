using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MD5.Tests
{
    [TestClass()]
    public class MD5Tests
    {
        [TestMethod()]
        public void MD5Test()
        {
            string str = UI.Common.MD5Encrypt.MD5Check("Lizhen");
            string str1 = "25686cc521a465bd821b851ca75882";
            Assert.AreEqual(str1, str);
        }
    }
}
