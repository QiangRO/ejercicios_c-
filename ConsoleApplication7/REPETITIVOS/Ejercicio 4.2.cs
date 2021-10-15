using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double ct=0;
            string p1;
            string p2;
            Console.WriteLine("Cuantas hamburguesas quieres?");
            n = int.Parse(Console.ReadLine());
            for(int c = 1; c <= n; c++)
            {
                Console.WriteLine("Para la hamburguesa " + c);
                do
                {
                    Console.WriteLine("Que tipo de hamburguesa?");
                    p1 = Console.ReadLine();
                
                } while (p1 != "s" && p1 != "d" && p1 != "t");
                do
                {
                    Console.WriteLine("Pagara con tarjeta?");
                    p2 = Console.ReadLine();
                } while (p2 != "si" && p2 != "no");
                switch (p1)
                {
                    case "s":
                        ct = ct + 20;
                        break;
                    case "d":
                        ct = ct + 25;
                        break;
                    case "t":
                        ct = ct + 28;
                        break;
                }
                if (p2 == "si")
                {
                    ct = ct + (ct * 0.05);
                }
            }
            Console.WriteLine("El costo total es:" + ct);
            Console.ReadKey();
        }
    }
}
