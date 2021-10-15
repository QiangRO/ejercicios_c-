using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio24
{
    class Program
    {
        public static void ejercicio()
        {
            double H, PH, C;

            Console.WriteLine("Cantidad de Horas");
            H = Convert.ToInt32(Console.ReadLine());

            PH = 25.5;

            C = H * PH;
            Console.WriteLine("El cobro total es: " + C);
            Console.ReadKey();
        }
    }
}
