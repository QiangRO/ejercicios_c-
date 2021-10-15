using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio52
{
    class Program
    {
        public static void ejercicio()
        {
        
            int[] a = new int[6];
            int[] b = new int[6];
            int j;

            Console.WriteLine("proceso de llenado del vector A");

            for(j=0;j<6;j++)
            {
                do
                {
                    Console.WriteLine("ingrese el valor de la posicion " + j + " :");
                    a[j] = int.Parse(Console.ReadLine());
                }
                while (a[j] < 0 || a[j] > 50);
                
            }
            Console.Clear();
            Console.WriteLine("proceso para invertir el vector");
            Console.WriteLine("Posicion  \t A  \t B  ");
            Console.WriteLine("┌──────────────────────────┐");

            for (j = 5; j >= 0; j--) 
            {
                b[5 - j] = a[j];
                Console.WriteLine("|"+(5 - j)+ "|\t\t" + a[5-j]+ "|\t" + b[5-j]);
            }

            Console.ReadKey();
        }
    }
}
