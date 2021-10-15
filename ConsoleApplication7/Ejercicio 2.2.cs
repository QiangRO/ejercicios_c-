using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio22
{
    class Program
    {
        public static void ejercicio()
        {
            double DM, VC, SUS;
            Console.WriteLine("Introducir Cantidad de Dinero");
            DM = Convert.ToInt32(Console.ReadLine());

            VC = 0.052;
            SUS = DM * VC;

            Console.WriteLine("El valor de cambio en dolares es: " + SUS);
            Console.ReadKey();

        }
    }
}
