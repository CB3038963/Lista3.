using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;

            Console.WriteLine("{0} ", b);

            for (int i = 0; i < 29; i++)

            {

                c = a + b;
                Console.WriteLine("{0} ", c);
                a = b;
                b = c;

            }
        }
    }
}
