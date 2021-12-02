using Complexidades;
using Xunit;

namespace TestProject1
{
    public class TempoLinear_Test
    {
        [Fact]
        public void Test1()
        {
            TempoLinear tempoLinear = new TempoLinear();

            int[] numeros = new int[] { 1, 2, 3, 4, 5 };

            tempoLinear.Linear(numeros);
        }


        [Fact]
        public void Test2()
        {
            TempoLinear tempoLinear = new TempoLinear();

            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            tempoLinear.Linear(numeros);
        }
    }
}
