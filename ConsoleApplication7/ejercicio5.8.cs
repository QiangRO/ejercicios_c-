using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio58
{
    class Program
    {
        public static void ejercicio()
        {
            int[] x = new int[15];
            int j,i;
            for (j = 0; j < 15;j++)
            {
                Console.WriteLine("ingrese el valor " + (j + 1));
                x[j] = int.Parse(Console.ReadLine()); 
            }
            for (i = 0; i < 15; i++)
            {
                int s1 =0;
                for (j = 1; j < x[i]; j++)
                {
                    if (x[i] % j == 0)
                    {
                        s1 = s1 + j;
                    }
                }
                int s2 = 0;
                for (j = 1; j < s1; j++)
                {
                    if (s1 % j == 0)
                    {
                        s2 = s2 + j;
                    }
                    
                }
                if (s2 == x[i])
                {
                    Console.WriteLine(x[i] + " es amigo de " + s1);
                }
                else
                {
                    Console.WriteLine(x[i]+" no tiene numero amigo");
                }
            }
            Console.ReadKey();
        }
    }
}
