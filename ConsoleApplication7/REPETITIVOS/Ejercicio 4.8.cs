using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double p;
            double d=0;
            double ct=0;
            double cf = 0;
            do
            {
                Console.WriteLine("Cuantos articulos quieres comprar?");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            
            for(int c = 1; c <= n; c++)
            {
                Console.WriteLine("Para el articulo "+c);
                Console.WriteLine("Cual es su precio?");
                p = double.Parse(Console.ReadLine());
                if (p >= 200)
                {
                    d = p * 0.15;
                    Console.WriteLine("El descuento es de " + d + " Bs");
                }
                if (p < 200 && p>100)
                {
                    d = p * 0.12;
                    Console.WriteLine("El descuento es de " + d + " Bs");
                }
                if (p <= 100)
                {
                    d = p * 0.10;
                    Console.WriteLine("El descuento es de " + d + " Bs");
                }
                ct = p - d;
                Console.WriteLine("El costo del articulo " + c + " es de " + ct + " Bs");
                cf = cf + ct;
            }
            Console.WriteLine("El costo total de todos los articulos es de " + cf + " Bs");
            Console.ReadKey();
        }
    }
}
