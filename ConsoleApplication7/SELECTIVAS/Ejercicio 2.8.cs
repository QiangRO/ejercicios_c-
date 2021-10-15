using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double V, D, TI;

            Console.Write("Introducir distancia: ");
            D = Convert.ToInt16(Console.ReadLine());

            V = 3;
            TI = D / V;
            Console.WriteLine("El tiempo total es: "+TI);
            Console.ReadKey();
        }
    }
}
