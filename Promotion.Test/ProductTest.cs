using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promotion.Model;
using Promotion.Service;

namespace Promotion.Test
{
    [TestClass]
    public class ProductTest
    {

        [TestMethod]
        public void GetTotalAmoutOfProductScenario1()
        {
            List<Product> productList = ProductData.ReturnCart1();
            int totalPrice = ProductService.GetTotalPrice(productList);
            Assert.AreEqual(100, totalPrice);
        }

        [TestMethod]
        public void GetTotalAmoutOfProductScenario2()
        {
            List<Product> productList = ProductData.ReturnCart2();
            int totalPrice = ProductService.GetTotalPrice(productList);
            Assert.AreEqual(370, totalPrice);
        }

        [TestMethod]
        public void GetTotalAmoutOfProductScenario3()
        {
            List<Product> productList = ProductData.ReturnCart3();
            int totalPrice = ProductService.GetTotalPrice(productList);
            Assert.AreEqual(280, totalPrice);
        }
    }
}
