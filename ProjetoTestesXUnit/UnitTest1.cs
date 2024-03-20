namespace ProjetoTestesXUnit
{
    public class ProjetoTestesXUnit_Testes
    {
        [Fact]
        //Facts testam condições invariantes (sempre verdadeiros)
        public void FactPassando()
        {
            Assert.Equal(4, Soma(2, 2));
        }

        [Fact]
        public void FactFalhando()
        {
            Assert.Equal(5, Soma(2, 2));
        }

        [Theory]
        //Theories testam condições que só serão verdadeiras para um determinado conjunto de dados
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void TheoryTeste(int valor)
        {
            Assert.True(EhImpar(valor));
        }

        int Soma(int a, int b) {  return a + b; }
        bool EhImpar(int valor) { return valor % 2 == 1; }
    }
}