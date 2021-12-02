using System;
using System.Collections.Generic;
using System.Text;

namespace Complexidades
{
    public class AlgoritmoGenerico
    {
        public void Foo(int[] numeros, int x)
        {
            var total = numeros.Length; //O(1)

            foreach(var n in numeros) //O(n)
            {
                if (n == x) //O(1)
                {
                    Console.WriteLine("Achei"); //O(1)
                }
            }

            Console.WriteLine("NaoAchei"); //O(1)
        }
    }
}

//Complexidade geral - O(n)