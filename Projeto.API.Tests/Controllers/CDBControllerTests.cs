using Moq;
using Projeto.API.Controllers;
using Projeto.API.Models;
using Projeto.API.Service;
using System.Web.Http;
using System.Web.Http.Results;
using Xunit;

namespace Projeto.API.Tests.Controllers
{
    public class CDBControllerTests
    {
        private readonly Mock<ICDBService> mockService;
        private readonly CDBController controller;

        public CDBControllerTests()
        {
            mockService = new Mock<ICDBService>();
            controller = new CDBController(mockService.Object);
        }

        [Fact]
        public void CalcularCdb_ValidInput_DeveRetornarOkComResultado()
        {
            // Arrange
            var input = new CDBInputModel { ValorInicial = 1000, Meses = 12 };
            var mockResult = new CDBResultModel { ValorBruto = 1100, ValorLiquido = 1050, Imposto = 50 };
            mockService.Setup(s => s.CalcularCDB(input.ValorInicial, input.Meses)).Returns(mockResult);

            // Act
            IHttpActionResult actionResult = controller.CalculaCDB(input);

            // Assert
            var contentResult = actionResult as OkNegotiatedContentResult<CDBResultModel>;
            Assert.NotNull(contentResult);
            Assert.Equal(mockResult, contentResult.Content);
        }

        [Fact]
        public void CalcularCdb_InputInvalido_DeveRetornarBadRequest()
        {
            // Arrange
            var input = new CDBInputModel { ValorInicial = -1000, Meses = 12 };

            // Act
            IHttpActionResult actionResult = controller.CalculaCDB(input);

            // Assert
            Assert.IsType<BadRequestErrorMessageResult>(actionResult);
        }
    }
}
