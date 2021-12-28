using BookShop.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookShop.Test
{
    [TestClass]
    public class TestConnectDb
    {
        [TestMethod]
        public void TestConnectionToDb()
        {
            var expect = BookShopDb.Init();
            Assert.IsNotNull(expect);
        }
    }
}