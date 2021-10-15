using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio26
{
    class Program
    {
        public static void ejercicio()
        {
            double A, B, C;
            Console.Write("Introducir Valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introducir Valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());
            
            C = A * A + B * B;

            Console.WriteLine("Valor de la Hipotenusa: " + C);
            Console.ReadKey();

        }
    }
}
