using MatrizEspiral.Domain;
using Xunit;

namespace MatrizEspiral.Test
{
    public class MatrizEspiralTest
    {
        [Fact]
        public void Quando3L3C_ComMatrizEsperadaCorreta_ValidaRetornoIgual()
        {
            //Arrange
            int qtdLinhas = 3;
            int qtdColunas = 3;
            int[,] matrizEsperada = { 
                { 1, 2, 3 }, 
                { 8, 9, 4 },
                { 7, 6, 5 }
            };

            //Act
            var matriz = new Matriz(qtdLinhas, qtdColunas);
            var matrizEspiral = matriz.ProcessaMatrizEspiral();

            //Assert
            Assert.Equal(matrizEsperada, matrizEspiral);
        }

        [Fact]
        public void Quando4L3C_ComMatrizEsperadaCorreta_ValidaRetornoIgual()
        {
            //Arrange
            int qtdLinhas = 4;
            int qtdColunas = 3;
            int[,] matrizEsperada = {
                { 1, 2, 3 },
                { 10, 11, 4 },
                { 9, 12, 5 },
                { 8, 7, 6 }
            };

            //Act
            var matriz = new Matriz(qtdLinhas, qtdColunas);
            var matrizEspiral = matriz.ProcessaMatrizEspiral();

            //Assert
            Assert.Equal(matrizEsperada, matrizEspiral);
        }

        [Fact]
        public void Quando3L3C_ComMatrizEsperadaInCorreta_ValidaRetornoDiferente()
        {
            //Arrange
            int qtdLinhas = 4;
            int qtdColunas = 3;
            int[,] matrizEsperada = {
                { 1, 2, 3 },
                { 4, 10, 11 },
                { 9, 12, 5 },
                { 8, 7, 6 }
            };

            //Act
            var matriz = new Matriz(qtdLinhas, qtdColunas);
            var matrizEspiral = matriz.ProcessaMatrizEspiral();

            //Assert
            Assert.NotEqual(matrizEsperada, matrizEspiral);
        }
    }
}
