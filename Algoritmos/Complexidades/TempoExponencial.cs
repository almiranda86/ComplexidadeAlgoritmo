using System;

namespace Complexidades
{
    public class TempoExponencial
    {
        public void IteraEAdiciona(int[] numeros)
        {
            foreach(var n in numeros)
            {
                foreach(var m in numeros)
                {
                    Console.WriteLine(n + m);
                }
            }
        }
    }
}
