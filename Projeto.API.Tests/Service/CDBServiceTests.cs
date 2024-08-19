using Projeto.API.Service;
using System;
using Xunit;

namespace Projeto.API.Tests.Service
{
    public class CDBServiceTests
    {
        private readonly ICDBService service;

        public CDBServiceTests()
        {
            service = new CDBService();
        }

        [Fact]
        public void CalcularCdb_DeveRetornarValorBrutoECorreto()
        {
            // Arrange
            decimal valorInicial = 1000;
            int meses = 12;

            // Act
            var resultado = service.CalcularCDB(valorInicial, meses);

            // Assert
            Assert.True(resultado.ValorBruto > valorInicial);
            Assert.Equal(1077.32m, resultado.ValorBruto, 2);
        }

        [Fact]
        public void CalcularCdb_DeveAplicarImpostoCorretamenteParaPrazoDe6Meses()
        {
            // Arrange
            decimal valorInicial = 1000;
            int meses = 6;

            // Act
            var resultado = service.CalcularCDB(valorInicial, meses);

            // Assert
            Assert.Equal(22.5m, resultado.Imposto, 2);
        }

        [Fact]
        public void CalcularCdb_DeveRetornarValorLiquidoCorreto_AposAplicacaoDoImposto()
        {
            // Arrange
            decimal valorInicial = 1000;
            int meses = 24;

            // Act
            var resultado = service.CalcularCDB(valorInicial, meses);

            // Assert
            Assert.True(resultado.ValorLiquido < resultado.ValorBruto);
        }

        [Fact]
        public void CalcularCdb_ValorInicialInvalido_DeveGerarExcecao()
        {
            // Arrange
            decimal valorInicial = -1000;
            int meses = 12;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => service.CalcularCDB(valorInicial, meses));
        }

        [Fact]
        public void CalcularCdb_MesesInvalido_DeveGerarExcecao()
        {
            // Arrange
            decimal valorInicial = 1000;
            int meses = 1000;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => service.CalcularCDB(valorInicial, meses));
        }
    }
}
