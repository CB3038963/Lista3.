using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double va, vb, m, t;
            do
            {
                Console.Write("Qual valor deseja fazer a tabuada: ");
                m = Convert.ToDouble(Console.ReadLine());
                Console.Write("A tabuada deve ser feita apartir de qual número: ");
                va = Convert.ToDouble(Console.ReadLine());
                Console.Write("Até o número: ");
                vb = Convert.ToDouble(Console.ReadLine());
                t = m * va;
            }
            while (va < 0 || vb < 0 || t <= 0);


            if (vb <= va)

            {
                Console.WriteLine("Digite o valor de B: ");

                vb = Convert.ToDouble(Console.ReadLine());
            }

            do
            {
                t = m * va;
                Console.WriteLine("{0} X {1} = {2}", m, va++, t);

            }

            while (va <= vb);
        }
    }
}
