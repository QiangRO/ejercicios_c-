using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio55
{
    class Program
    {
        public static void ejercicio()
        {
            int[] edad=new int[4];
            byte n=1;
            int j;
            for (j = 0; j < 4; j++)
              
            {
                do
                {
                    
                    Console.WriteLine("ingrese la edad: "+n);
                    edad[j] = int.Parse(Console.ReadLine());
                    n++;

                }
                while (edad[j] < 15 || edad[j] > 21);
                
             
            }
            Console.Clear();
            n = 1;
            for (j=0;j<4;j++)
            {
                
                Console.WriteLine("las edad "+n+" es \t" + edad[j]);
                n++;
            }
            Console.ReadKey();
        }
    }
}
