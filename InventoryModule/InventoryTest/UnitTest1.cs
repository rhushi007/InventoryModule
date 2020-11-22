using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InventoryModule.Controllers;
using System.Web.Mvc;

namespace InventoryTest
{
    [TestClass]
    public class InventoriesTest
    {
        [TestMethod]
        public void TestIndex()
        {
            InventoriesController obj = new InventoriesController();
            var result = obj.Index() as ViewResult;
            Assert.AreEqual("Index",result.ViewName);
        }
        [TestMethod]
        public void TestCreate()
        {
        }
    }
}
