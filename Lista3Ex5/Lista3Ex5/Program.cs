using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, r;

            Console.WriteLine("Numero da tabuada a ser feita: ");
            n = Convert.ToDouble(Console.ReadLine());
            if (n < 0)

                do
                {
                    Console.WriteLine("Numero da tabuada a ser feita: ");
                    n = Convert.ToDouble(Console.ReadLine());
                } while (n < 0);

            for (int i = 1; i < 11; i++)
            {


                r = n * i;
                Console.WriteLine("{0} ", r);

            }
        }
    }
}
