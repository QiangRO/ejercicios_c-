using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio54
{
    class Program
    {
        public static void ejercicio()
        {
            int[] x = new int[15];
            int suma = 0,prom,mayor,menor,par;
            int j =0;
            for (j = 0; j < 15; j++)
            {
               do
                     {
                    Console.WriteLine("ingrese el valor " + (j+1));
                x[j] = int.Parse(Console.ReadLine());
                     } while (x[j] < 0 || x[j] > 100) ;
                 suma = suma + x[j];
            }
            prom = suma / 15;
            mayor = x[0];
            menor = mayor;
            
            for (j=0;j<15;j++)
            {
                
                if (x[j]>mayor)
                {
                    mayor = x[j];
                }
                if (x[j]< menor)
                {
                    menor=x[j] ;
                }
            }
            for (j = 0; j < 15; j++)
            {
                if (x[j] % 2 != 0)
                {
                    x[j]=x[j] + 1;
                }
                
                
            }
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Lista de el vector en pares");
            for (j = 0; j < 15; j++)
            {
                Console.WriteLine("\t" + x[j]);
            }
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("el numero mayor " + mayor + " el numero  menor " + menor);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("la suma es "+suma+" \t  el promedio es  "+prom);
            Console.ReadKey();
        }
    }
}
