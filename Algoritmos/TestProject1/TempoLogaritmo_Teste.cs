using Complexidades;
using Xunit;

namespace TestProject1
{
    public class TempoLogaritmo_Teste
    {
        [Fact]
        public void Test1()
        {
            TempoLogaritmo tempoLogaritmo = new TempoLogaritmo();

            int[] numeros = new int[] { 1, 2, 3, 4, 5 };

            var result = tempoLogaritmo.Logaritmo(numeros, 4);

            Assert.Equal(4, result);
        }


        [Fact]
        public void Test2()
        {
            TempoLogaritmo tempoLogaritmo = new TempoLogaritmo();

            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = tempoLogaritmo.Logaritmo(numeros, 8);

            Assert.Equal(8, result);
        }
    }
}
