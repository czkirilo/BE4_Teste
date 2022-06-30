using Projeto_teste2;

namespace TestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //PREPARACAO - Arrange
            double banana = 1;
            double mamao = 1;
            double rNUM = 2;

            //ACAO - Act

            var resultado = operacoes.Somar(banana, mamao);
            
            //VERIFICACAO - Assert
            Assert.AreEqual(rNUM, resultado);

        }

        [DataTestMethod]
        [DataRow(9, 4, 13)]
          public void ListaDeSoma(double pNum, double melao, double resultadoesperado)
        {
            // act
            var resultadoreal = operacoes.Somar(pNum, melao);

            // Assert
            Assert.AreEqual(resultadoesperado, resultadoreal);
        }
    }
}