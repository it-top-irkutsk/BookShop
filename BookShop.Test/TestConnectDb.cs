using System.Linq;
using BookShop.Lib;
using BookShop.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookShop.Test
{
    [TestClass]
    public class TestConnectDb
    {
        [TestMethod]
        public void Test_ConnectionToDb()
        {
            var expect = BookShopDb.Init();
            Assert.IsNotNull(expect);
        }

        [TestMethod]
        public void Test_TabAuthors_IsNotNull()
        {
            var db = BookShopDb.Init();
            var expect = db.TabAuthors;
            Assert.IsNotNull(expect);
        }

        [TestMethod]
        public void Test_TabAuthors_TestAuthor()
        {
            var actual = new Author
            {
                Id = 1,
                FirstName = "Харлан",
                LastName = "Эллисон"
            };

            var db = BookShopDb.Init();
            var expect = db.TabAuthors.First();
            
            Assert.AreEqual(expect, actual);
        }
        
        [TestMethod]
        public void Test_TabBooks_IsNotNull()
        {
            var db = BookShopDb.Init();
            var expect = db.TabBooks;
            Assert.IsNotNull(expect);
        }
        
        [TestMethod]
        public void Test_TabEditions_IsNotNull()
        {
            var db = BookShopDb.Init();
            var expect = db.TabEditions;
            Assert.IsNotNull(expect);
        }
        
        [TestMethod]
        public void Test_TabGenres_IsNotNull()
        {
            var db = BookShopDb.Init();
            var expect = db.TabGenres;
            Assert.IsNotNull(expect);
        }
        
        [TestMethod]
        public void Test_TabPrices_IsNotNull()
        {
            var db = BookShopDb.Init();
            var expect = db.TabPrices;
            Assert.IsNotNull(expect);
        }
        
        [TestMethod]
        public void Test_TabPublishingHouses_IsNotNull()
        {
            var db = BookShopDb.Init();
            var expect = db.TabPublishingHouses;
            Assert.IsNotNull(expect);
        }
    }
}