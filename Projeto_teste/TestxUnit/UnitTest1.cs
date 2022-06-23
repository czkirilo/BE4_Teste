using Projeto_teste;

namespace TestxUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //arrange - Preparacao
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - Acao
            var resultado = operacoes.Somar(pNum, sNum);

            //assert
            Assert.Equal(rNum, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(4, 4, 8)]
        [InlineData(10, 10, 20)]
        [InlineData(150, 15, 165)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = operacoes.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);
        }

        [Fact]
        public void SubtrairDoisNumeros()
        {
            //arrange
            double pNum = 2;
            double sNum = 1;
            double rNum = 1;

            //act
            var resultado = operacoes.Subtrair(pNum, sNum);

            //Assert 
            Assert.Equal(rNum, resultado);
        }
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 2, 3)]
        [InlineData(3, 1, 2)]
        public void SubtrairDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act 
            var resultado = operacoes.Subtrair(pNum, sNum);

            //assert
            Assert.Equal(rNum, resultado);
        }
    }
}