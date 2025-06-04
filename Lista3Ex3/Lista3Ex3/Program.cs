using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string gen;
            Console.WriteLine("Genero F mulher , M homem : ");
            gen = Convert.ToString(Console.ReadLine());

            do
            {
                Console.Write("Genero F mulher , M homem : ");
                gen = Convert.ToString(Console.ReadLine());
            }
            while (gen != "F" && gen != "M");
        }
    }
}
