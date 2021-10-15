using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int aa = 0;
            for (int d=1;d<= 365; d++)
            {
                a = Math.Pow(3,d);
                aa = aa + a;
                Console.WriteLine("El dia " + d + " ahorra " + a + "Bs");
            }
            Console.WriteLine("Ahorro un total de " + aa + "Bs en todo el año");
            Console.ReadKey();
        }
    }
}
