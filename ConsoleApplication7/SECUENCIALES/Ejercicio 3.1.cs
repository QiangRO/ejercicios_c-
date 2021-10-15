using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
         int edad;

            Console.WriteLine("introduce edad");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("puede votar" + edad);
            }
            else
            {
                Console.WriteLine("no puede votar" + edad);
            }
            Console.ReadKey();
        }
    }
}
