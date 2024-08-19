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
        private readonly Mock<ICdbService> mockService;
        private readonly CdbController controller;

        public CDBControllerTests()
        {
            mockService = new Mock<ICdbService>();
            controller = new CdbController(mockService.Object);
        }

        [Fact]
        public void CalcularCdb_ValidInput_DeveRetornarOkComResultado()
        {
            // Arrange
            var input = new CdbInputModel { ValorInicial = 1000, Meses = 12 };
            var mockResult = new CdbResultModel { ValorBruto = 1100, ValorLiquido = 1050, Imposto = 50 };
            mockService.Setup(s => s.CalcularCDB(input.ValorInicial, input.Meses)).Returns(mockResult);

            // Act
            IHttpActionResult actionResult = controller.CalculaCDB(input);

            // Assert
            var contentResult = actionResult as OkNegotiatedContentResult<CdbResultModel>;
            Assert.NotNull(contentResult);
            Assert.Equal(mockResult, contentResult.Content);
        }

        [Fact]
        public void CalcularCdb_InputInvalido_DeveRetornarBadRequest()
        {
            // Arrange
            var input = new CdbInputModel { ValorInicial = -1000, Meses = 12 };

            // Act
            IHttpActionResult actionResult = controller.CalculaCDB(input);

            // Assert
            Assert.IsType<BadRequestErrorMessageResult>(actionResult);
        }
    }
}
