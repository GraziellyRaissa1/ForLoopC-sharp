using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopCsharp
{
    internal class Exemplo03
    {
        public static void Main(string[] args)
        {
            // Loop externo
            for (int A = 1; A <= 2; ++A)
            {
                Console.WriteLine("Externo: " + A);  // Execultar 2 vezes

                // Loop interno
                for (int B = 1; B <= 3; B++)
                {
                    Console.WriteLine(" Inner: " + B);  // Execultar 6 vezes (2 * 3)
                }
            }
    }   }
}
