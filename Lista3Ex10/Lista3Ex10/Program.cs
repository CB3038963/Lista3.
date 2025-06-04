using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            double maior = 0;
            double soma = 0;
            double media = 0;

            for (int i = 1; i < 11; i++)
            {
                Console.Write("{0}  valor: ", i);
                num = Convert.ToDouble(Console.ReadLine());
                if (num < 0)
                {
                    do
                    {
                        Console.Write("Por favor, digite um valor positivo para o {0} valor: ",i);
                        num = Convert.ToDouble(Console.ReadLine());
                    } while (num < 0);
                    
                }
                if (num > maior)
                {
                    maior = num;
                }
                soma = soma + num;
                media = soma / i;
            }

            Console.WriteLine();
            Console.WriteLine("MAIOR {0}", maior);
            Console.WriteLine("SOMA  {0}", soma);
            Console.WriteLine("MEDIA {0}", media);
        }
    }
}
