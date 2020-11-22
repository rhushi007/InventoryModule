using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InventoryModule.Controllers;
using System.Web.Mvc;
using InventoryModule.Models;

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
            InventoriesController obj = new InventoriesController();
            var result = obj.Create() as ViewResult;
            Assert.AreEqual("Create", result.ViewName);
        }
        [TestMethod]
        public void TestEdit()
        {
            InventoriesController obj = new InventoriesController();          
             var result = obj.Edit(2) as PartialViewResult;
            Assert.AreEqual("_edit", result.ViewName);
        }
        [TestMethod]
        public void TestDetails()
        {
            InventoriesController obj = new InventoriesController();
            var result = obj.Details(2) as PartialViewResult;
            Assert.AreEqual("_details", result.ViewName);
        }
        [TestMethod]
        public void TestDelete()
        {
            InventoriesController obj = new InventoriesController();
            var result = obj.Delete(2) as PartialViewResult;
            Assert.AreEqual("_delete", result.ViewName);
        }
    }
}
