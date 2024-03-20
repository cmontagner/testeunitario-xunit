namespace ProjetoTestesXUnit
{
    public class ProjetoTestesXUnit_Testes
    {
        [Fact]
        public void TestePassando()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void TesteFalhando()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int a, int b) {  return a + b; }
    }
}