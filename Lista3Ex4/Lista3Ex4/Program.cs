using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i, num;
            i = 00;
            num = 00;


            do
            {
                i = i + 5;
                num++;
                Console.WriteLine("5 x {0} = {1}", num, i);
            }

            while (num < 10);
        }
    }
}
