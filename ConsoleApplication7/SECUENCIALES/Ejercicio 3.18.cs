using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
         
            double b1;
            double b2;
            int a;
            double bm;
            Console.WriteLine("introducir bono mensual");
            bm = double.Parse(Console.ReadLine());
            Console.WriteLine("introducir año de antiguiedad");
            a = int.Parse(Console.ReadLine());
            if (a > 2 && a < 5)
            {
                b1 = bm * 0.2;
                Console.WriteLine("cuanto es su bono" + b1);
            }
            else
            {
                b1 = bm * 0.3;
                Console.WriteLine("cuanto es su bono" + b1);
            }
            if (bm < 1000)
            {
                b2 = bm * 0.25;
                Console.WriteLine("cuanto es su bono" + b2);
            }
            else
            {
                if (bm > 1000 && bm <= 3500)
                {
                    b2 = bm * 0.15;
                    Console.WriteLine("cuanto es su bono" + b2);
                }
                else
                {
                    b2 = bm * 0.1;
                    Console.WriteLine("cuanto es su bono" + b2);
                }
            }
            Console.ReadKey();
        }
    }
}
