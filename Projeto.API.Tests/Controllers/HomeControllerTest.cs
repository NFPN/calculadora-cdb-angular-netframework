using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.API.Controllers;
using System.Web.Mvc;

namespace Projeto.API.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("API RUNNING", result.ViewBag.Message);
        }
    }
}
