﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using uh365898_db.Domain.Abstract;
using uh365898_db.Domain.Entities;
using uh365898_db.WebUI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace uh365898_db.UnitTests
{
    [TestClass]
    public class AdminTests
    {
        [TestMethod]
        public void Index_Contains_All_Products()
        {
            // Arrange - create the mock repository
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[] {
        new Product {ProductID = 1, Name = "P1"},
        new Product {ProductID = 2, Name = "P2"},
        new Product {ProductID = 3, Name = "P3"},
      }.AsQueryable());
            // Arrange - create a controller
            ControlsystemController target = new ControlsystemController(mock.Object);
            // Action
            Product[] result = ((IEnumerable<Product>)target.Mainpage().ViewData.Model).ToArray();
            // Assert
            Assert.AreEqual(result.Length, 3);
            Assert.AreEqual("P1", result[0].Name);
            Assert.AreEqual("P2", result[1].Name);
            Assert.AreEqual("P3", result[2].Name);

        }
    }
}
