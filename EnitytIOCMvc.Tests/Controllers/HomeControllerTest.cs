using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnitytIOCMvc;
using EnitytIOCMvc.Controllers;
using Microsoft.Practices.Unity;
using EnitytIOCMvc.Code.Utility;

namespace EnitytIOCMvc.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private static ILogger logger;
        private static UnityContainer container = new UnityContainer();

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            container.RegisterType<ILogger, ConsoleLogger>();
            logger = container.Resolve<ILogger>();
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(logger);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController(logger);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController(logger);

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
