using Complexidades;
using Xunit;

namespace TestProject1
{
    public class TempoExponencial_Test
    {
        [Fact]
        public void Test1()
        {
            TempoExponencial tempoExponencial = new TempoExponencial();

            int[] numeros = new int[] { 1, 2, 3, 4, 5 };

            tempoExponencial.IteraEAdiciona(numeros);
        }


        [Fact]
        public void Test2()
        {
            TempoExponencial tempoExponencial = new TempoExponencial();

            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            tempoExponencial.IteraEAdiciona(numeros);
        }
    }
}
