using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio59
{
    class Program
    {
        public static void ejercicio()
        {
            int[] a = new int[30];
            int[] b = new int[25];
            int j,i;
            for (j = 0; j < 30; j++)
            {
                a[j] = j + 1;
            }
            for (j = 0; j < 75; j++)
            {
                
                    Random random = new Random();
                    int x = random.Next(0, 74);
                    int y = random.Next(0, 74);
                    for (i = 0; i < 75; j++)
                    {
                        do
                        {
                            if (b[j] == x)
                            {
                                x = random.Next(0, 74);
                            }
                            if (b[j]== y)
                            {
                                y = random.Next(0, 74);
                            }
                           
                        }
                        while (x == y);
                        Console.WriteLine("alumno " + a[j] + "ejercicios " + b[x] + " " + b[y]);
                    }
                }
            
            Console.ReadKey();

        }
    }
}
