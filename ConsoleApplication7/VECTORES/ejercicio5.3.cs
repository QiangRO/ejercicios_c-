using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio53
{
    class Program
    {
        public static void ejercicio()
        {
            int[] x = new int[15];
            int suma = 0,aldes=0,prom;
            int j = 0;
            for (j = 0; j < 15; j++)
            {
                do
                {
                    Console.WriteLine("ingrese la calificacion " + (j + 1));
                    x[j] = int.Parse(Console.ReadLine());
                }
                while (x[j] < -1 || x[j] > 100);
                suma = suma + x[j];
            }
            prom = suma / 15;
            for (j = 0; j < 15; j++)
            {
                if (x[j] > prom)
                {
                    aldes++;
                }
            }
            Console.WriteLine("el promedio del curso es de: " + prom);
            Console.WriteLine("y los alumnos que superaron el promedio son: " + aldes);
            Console.ReadKey();
        }
    }
}
