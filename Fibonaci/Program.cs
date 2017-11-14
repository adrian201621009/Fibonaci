using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1 = 1, n2 = 1, n3, cont;

            for (cont = 1; cont <5; cont++)
            {
                n3 = n1 + n2;
                Console.Write(n3);
                n1 = n2;
                n2 = n3;
                Console.WriteLine(" -- " + (n2 / n1));
            }
            Console.ReadKey();
        }
    }
}
