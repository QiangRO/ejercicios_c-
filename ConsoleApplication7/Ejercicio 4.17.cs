using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio417
{
    class Program
    {
        public static void ejercicio()
        {
            int k;
            int i=0;
            int m;
            do
            {
                Console.WriteLine("Digite un numero positivo");
                k = int.Parse(Console.ReadLine());
            } while (k < 0);
            while (i <= k)
            {
                m = k * i;
                i++;
                Console.WriteLine(m);
            }
            Console.ReadKey();
        }
    }
}
