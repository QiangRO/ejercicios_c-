using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio210
{
    public class Program
    {
        public static void ejercicio()
        {
            double m3, P, VA;
            
            Console.WriteLine("Introducir los m3");
            m3 = double.Parse(Console.ReadLine());

            VA = 2.5;
            P = m3 * VA;

            Console.WriteLine();
            Console.WriteLine("pago del agua es :" + P);
            Console.ReadKey(); 
        }
    }
}
