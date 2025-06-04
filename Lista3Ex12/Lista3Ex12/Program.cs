using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string q;
            do
            {
                double n;
                Console.WriteLine("Quantos numeros ira inserir: ");
                n = Convert.ToDouble(Console.ReadLine());
                if (n < 0 || n >= 20)
                {
                    do
                    {
                        Console.WriteLine("Digite um numero positivo e menor que 20: ");
                        n = Convert.ToDouble(Console.ReadLine());



                    } while (n < 0 || n > 19);
                }
                double num;
                double soma = 0;
                double m = 0;
                double p = 0;
                double pern = 0, perp = 0;

                Console.WriteLine("VALORES PODEM SER POSITIVOS E/OU NEGATIVOS");
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("{0} valor: ", i);
                    num = Convert.ToDouble(Console.ReadLine());
                    if (m <= num)
                    {
                        m = num;
                    }
                    if (p >= num)
                    {
                        p = num;
                    }

                    if (num > 0 || num < 0)
                    {
                        soma = soma + num;
                    }
                    if (num > 0)
                    {
                        perp = perp + 1;
                    }
                    if (num < 0)
                    {
                        pern = pern + 1;
                    }
                }
                double pernt = (pern / n) * 100;
                double perpt = (perp / n) * 100;

                Console.WriteLine("MAIOR NUMERO {0}", m);
                Console.WriteLine("MENOR NUMERO {0}", p);
                Console.WriteLine("PORCENTAGEM DE VALORES POSITIVOS {0} %", perpt);
                Console.WriteLine("PORCENTAGEM DE VALORES NEGATIVOS {0} % ", pernt);

                Console.WriteLine("");

                Console.WriteLine("FAZER NOVA EXECUÇÃO?");
                q = Convert.ToString(Console.ReadLine());

                if ((q.ToLower() != "s") && (q.ToLower() != "n"))
                {
                    do
                    {
                        Console.WriteLine("RESPONDA COM S OU N");
                        q = Convert.ToString(Console.ReadLine());
                    } while ((q.ToLower() != "s") && (q.ToLower() != "n"));
                }

                Console.WriteLine("");

            } while (q.ToLower() == "s");
        }
    }
}
