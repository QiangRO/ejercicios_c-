using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio510
{
    class Program
    {
        public static void ejercicio()
        {
            int[] ejer = new int[74];
            int[] asig = new int[59];
            int[] libre = new int[14];
            int j;
            int aux = 0;
            int alum = 31;
            Random random = new Random();
            int ran = random.Next(61,75);
            Random random1 = new Random();
            int ran2 = random.Next(60, 67);
            Console.WriteLine("alumnos Nº \t Ejer. unicos \t adicional");
            for (j = 0; j < 29; j++)
            {
                
                Console.WriteLine((alum - 1)+"  \t\t     "+(aux + 1)+","+(aux + 2)+"\t  " + (ran2) + " -"+ (ran2 + 8));
                alum=alum - 1;
                Random random2 = new Random();
                int ran3 = random.Next(60, 67);
                aux = aux + 2;
                ran2 = ran3;
            }

            Console.WriteLine((alum - 1)+"  \t\t     "+(aux + 1)+","+(aux + 2)+"\t  " + (ran2) + " -"+ (ran2 + 8));


            Console.ReadKey();
        }
    }
}
