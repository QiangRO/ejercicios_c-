using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int años;
            int mes;
            double ames=0;
            double aaño=0;
            int c=1;
            Console.WriteLine("Cuantos años?");
            años = int.Parse(Console.ReadLine());
            while( c <= años)
            {
                
                for( mes=1;mes<=12;mes++)
                {
                    Console.WriteLine("Cuanto ahorro el mes " + mes + " del año " + c + "?");
                    ames = double.Parse(Console.ReadLine());
                    aaño = aaño + ames;
                }
                aaño = aaño - (aaño * 0.10);
                Console.WriteLine("El ahorro del año " + c + " es de: " + aaño + " Bs");
                c++;
                ames = 0;
                aaño = 0;
                mes = 1;
            }
            Console.ReadKey();
        }
    }
}
