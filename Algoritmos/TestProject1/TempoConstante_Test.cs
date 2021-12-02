using Complexidades;
using Xunit;

namespace TestProject1
{
    public class TempoConstante_Test
    {
        [Fact]
        public void Test1()
        {
            TempoConstante tempoConstante = new TempoConstante();

            int[] numeros = new int[] { 1, 2, 3, 4, 5 };

            tempoConstante.Constante(numeros);
        }


        [Fact]
        public void Test2()
        {
            TempoConstante tempoConstante = new TempoConstante();

            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            tempoConstante.Constante(numeros);
        }
    }
}
