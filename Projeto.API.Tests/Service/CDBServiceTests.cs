using Projeto.API.Service;
using System;
using Xunit;

namespace Projeto.API.Tests.Service
{
    public class CDBServiceTests
    {
        private readonly CdbService service;

        public CDBServiceTests()
        {
            service = new CdbService();
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
            Assert.True(resultado.ValorLiquido > 1098 && resultado.ValorLiquido < 1099);
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
            Assert.Equal(0.225m, resultado.Imposto, 3);
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
            Assert.Throws<InvalidOperationException>(() => service.CalcularCDB(valorInicial, meses));
        }

        [Fact]
        public void CalcularCdb_MesesInvalido_DeveGerarExcecao()
        {
            // Arrange
            decimal valorInicial = 1000;
            int meses = 1000;

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => service.CalcularCDB(valorInicial, meses));
        }
    }
}
