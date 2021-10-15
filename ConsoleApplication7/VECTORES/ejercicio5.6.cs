using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio56
{
    class Program
    {
        public static void ejercicio()
        {
            int[] x = new int[10];
            int j;
            for (j = 0; j < 10; j++)
            {
                do
                {
                    Console.WriteLine("ingrese un numero entre 1 y 20");
                    x[j] = int.Parse(Console.ReadLine());
                }
                while (x[j] < 0 || x[j] > 20);

            }
            int suma = 0;
            for (j=0;j<10;j++)
            {
                suma = suma + x[j];
            }
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("La suma es de: " + suma);
            Console.ReadKey();
        }
    }
}
