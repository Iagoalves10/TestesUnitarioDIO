using Xunit;
using Calculadora;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calculadora = new Calculadora();

        [Fact]
        public void Adicionar_DeveRetornarResultadoCorreto()
        {
            // Arrange
            double a = 5;
            double b = 3;
            double resultadoEsperado = 8;

            // Act
            double resultado = _calculadora.Adicionar(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Subtrair_DeveRetornarResultadoCorreto()
        {
            // Arrange
            double a = 5;
            double b = 3;
            double resultadoEsperado = 2;

            // Act
            double resultado = _calculadora.Subtrair(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Multiplicar_DeveRetornarResultadoCorreto()
        {
            // Arrange
            double a = 5;
            double b = 3;
            double resultadoEsperado = 15;

            // Act
            double resultado = _calculadora.Multiplicar(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Dividir_DeveRetornarResultadoCorreto()
        {
            // Arrange
            double a = 6;
            double b = 3;
            double resultadoEsperado = 2;

            // Act
            double resultado = _calculadora.Dividir(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Dividir_DeveLancarExcecaoQuandoDivisorZero()
        {
            // Arrange
            double a = 6;
            double b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(a, b));
        }
    }
}
