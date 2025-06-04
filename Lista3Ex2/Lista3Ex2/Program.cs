using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1,n2;
            
                Console.Write("1° valor positivo: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("2° valor positivo: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                        if (n1>n2)
                        do
                        {
                        Console.Write("2° valor positivo: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        } while(n2<n1);
            
               

        
        }
    }
}
