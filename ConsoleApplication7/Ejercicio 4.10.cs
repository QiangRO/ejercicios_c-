using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio410
{
    class Program
    {
        public static void ejercicio()
        {
            int s;
            int a;
            int e;
            int i=1, j=1;
            int p=0;
            int pt=0;
            Console.WriteLine("Cuantos salones hay?");
            s = int.Parse(Console.ReadLine());
            while (i <= s)
            {
                Console.WriteLine("Cuantos alumnos tiene el salon " + i + "?");
                a = int.Parse(Console.ReadLine());
                while (j <= a)
                {
                    Console.WriteLine("Digite la edad del alumno " + j);
                    e = int.Parse(Console.ReadLine());
                    p = p + e;
                    j++;                
                }
                p = p / a;
                pt = pt + p;
                p = 0;
                i++;
            }
            pt = pt / s;
            Console.WriteLine("El promedio total del colegio es: " + pt);
            Console.ReadKey();
        }
    }
}
