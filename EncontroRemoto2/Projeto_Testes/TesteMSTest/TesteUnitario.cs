using Projeto_Testes;

namespace TesteMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange - preparacao
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act = Acao/Execucao
            var Resultado = operacoes.Somar(pNum, sNum);
            //Assert - Verificacao
            Assert.AreEqual(rNum, Resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 3)]
        [DataRow(3, 3, 6)]
        [DataRow(4, 1, 5)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act 2
            var resultado = operacoes.Somar(pNum, sNum);

            //Assert 2
            Assert.AreEqual(rNum, resultado);
        }
    }
}