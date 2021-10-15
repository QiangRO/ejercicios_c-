using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int x;
            int i = 1;
            double c;
            Console.WriteLine("Digite el total de numeros");
            n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                do
                {
                    Console.WriteLine("Digite un numero positivo");
                    x = int.Parse(Console.ReadLine());
                } while (x < 0);
                c= Math.Pow(x, 3);
                Console.WriteLine("El cubo de " + i + " es " + c);
            }
            Console.ReadKey();
        }
    }
}
