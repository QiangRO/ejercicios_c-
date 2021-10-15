using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo;
            string toma;
            string lent;
            string enf;
            int edad;
            int cb;
            double e5;
            double e10;
            double e20;
            double total;
            Console.WriteLine("Introdusca el tipo de Seguro A/B");
            tipo = (Console.ReadLine());
            Console.WriteLine("Es alcoholico SI/NO");
            toma = (Console.ReadLine());
            Console.WriteLine("Utiliza lentes SI/NO");
            lent = (Console.ReadLine());
            Console.WriteLine("Tiene alguna enfermedad SI/NO");
            enf = (Console.ReadLine());
            Console.WriteLine("Introdusca la edad");
            edad = int.Parse(Console.ReadLine());
            if (tipo == "A")
            {
                cb = 1200;
            }
            else
            {
                cb = 950;
            }
            e5 = (cb * 5) / 100;
            e10 = (cb * 10) / 100;
            e20 = (cb * 20) / 100;
            if (toma == "SI")
            {
                total = cb + e10;
            }
            else
            {
            }
            if (lent == "SI")
            {
                total = cb + e5;
            }
            else
            {
            }
            if (enf == "SI")
            {
                total = cb + e5;
            }
            else
            {
            }
            if (edad > 40)
            {
                total = cb + e20;
            }
            else
            {
                total = cb + e10;
            }
            Console.WriteLine("EL TOTAL ES: "+total);
            Console.ReadKey();
        }
    }
}
