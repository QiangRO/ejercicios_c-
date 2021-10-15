using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio316
{
    class Program
    {
        public static void ejercicio()
        {
         int s;
         int p;
         double pr;
         double sm;

            Console.WriteLine("introduce los puntos");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("introduce salario");
            s = int.Parse(Console.ReadLine());
            if (p > 151)
            {
                sm = s * 0.45;
                pr = sm * 3;
                Console.WriteLine("cuanto es su premio" + pr);
            }
            else
            {
                if (p > 101 && p < 150)
                {
                    sm = s * 0.45;
                    pr = sm * 2;
                    Console.WriteLine("cuanto es su premio" + pr);
                }
                else
                {
                    pr = s;
                    Console.WriteLine("cuanto es su premio" + pr);
                }
            }
            Console.ReadKey();
        }
    }
}

