using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p;

            double a = 1, b = 1, c;

            for (int i = 1; i < 21; i++)
            {
                Console.Write("Digite algo");
                p = Convert.ToString(Console.ReadLine());
                do
                {
                    c = a * b;
                    Console.WriteLine("{0}x{1}={2}", a, b, c);
                    b++;
                } while (b < 11);
                a++;
                b = 1;
            }
        }
    }
}
