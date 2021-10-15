using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio57
{
    class Program
    {
        public static void ejercicio()
        {
            byte n=0;
            byte n1 = 0;
            byte tam;
            int j;

            do
            {
                Console.WriteLine("ingrese el tamaño de los vectoes");
                tam = byte.Parse(Console.ReadLine());
            }
            while (tam < 5 || tam > 10);

            int[] v1 = new int[10];
            int[] v2 = new int[10];
            int[] v3 = new int[10];

            for (j=0;j<tam;j++)
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("ingrese el valor de la casilla " + n+" del ");



                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" primer vector ");
                    v2[j] = int.Parse(Console.ReadLine());

                }
                while (v1[j] < 1 || v1[j] > 20);n++;

                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("ingrese el valor de la casilla " + n1+ "del");



                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" segundo vector");
                    v2[j] = int.Parse(Console.ReadLine());


                }
                while (v2[j] < 1 || v2[j] > 20);n1++;
            }
            n = 0;
            for(j=0;j<tam;j++)
            {
                v3[j] = v1[j] + v2[j];
                Console.WriteLine("la suma de la casilla " + n + "es de: " + v3[j]);
                n++;
            }
            Console.ReadKey();
        }
    }
}
