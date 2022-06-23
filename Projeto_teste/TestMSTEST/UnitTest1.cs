using Projeto_teste;

namespace TestMSTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //arrange - Preparacao
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act- Acao
            var resultado = operacoes.Somar(pNum, sNum);

            //Assert - Verificacao
            Assert.AreEqual(rNum, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(1, 2, 3)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //act - Acao
            var resultado = operacoes.Somar(pNum, sNum);

            //assert - verificacao
            Assert.AreEqual(rNum, resultado);

        }


        [TestMethod]
        public void SubtrairDoisNumeros()
        {
            //arrange - preparacao
            double pNum = 2;
            double sNum = 1;
            double rNum = 1;

            //act - acao
            var resultado = operacoes.Subtrair(pNum, sNum);

            //assert - verificacao
            Assert.AreEqual(rNum, resultado);
        }

        [DataTestMethod]
        [DataRow(5, 2, 3)]
        [DataRow(2, 5, -3)]
        [DataRow(3, 3, 0)]
        [DataRow(4, 1, 3)]
        [DataRow(100, 99, 1)]
        public void SubtrairDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //act - acao
            var resultado = operacoes.Subtrair(pNum, sNum);

            //Assert - verificacao
            Assert.AreEqual(rNum, resultado);
        }
    }
}