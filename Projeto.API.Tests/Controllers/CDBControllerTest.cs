using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.API.Controllers;
using Projeto.API.Service;

namespace Projeto.API.Tests.Controllers
{
    [TestClass]
    public class CDBControllerTest
    {
        //Test1 working scenario
        //Test2 failing scenario
        //Test3 big value
        //Test4 negative values
        //Teste 5 1800 dias

        [TestMethod]
        public void Post()
        {
            // Arrange
            CDBController controller = new CDBController(new CDBService());

            // Act

            // Assert
        }
    }
}
