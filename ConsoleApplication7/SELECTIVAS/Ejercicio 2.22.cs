using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            double M;
            double CM;
            double CT;
            Console.WriteLine("Digite los minutos");
            M = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el costo por minuto");
            CM = double.Parse(Console.ReadLine());
            CT = M * CM;
            Console.WriteLine("El costo total es: " + CT);
            Console.ReadKey();
        }
    }
}
