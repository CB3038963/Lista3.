using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double num;

            do
            {
                Console.Write("Digite um valor positivo: ");
                num = Convert.ToDouble(Console.ReadLine());
            } while (num < 0);
        }
    }
}
