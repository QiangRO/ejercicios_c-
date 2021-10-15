using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double des;
            double pr;

            Console.WriteLine("introducir precio del articulo");
            a = int.Parse(Console.ReadLine());
            des = 0;
            pr = 0;
            if (a >= 200)
            {
                des = a*0.15;
                pr = a - des;
            }
            else
            {
                if (a > 100 && a < 200)
                {
                    des = a * 0.12;
                    pr = a - des;
                }
                else
                {
                    if (a < 100)
                    {
                        des = a * 0.1;
                        pr = a - des;
                    }
                    else
                    {
                    }
                }
            }
            Console.WriteLine("cuanto es su descuento: "+ des);
            Console.WriteLine("cuanto es su costo: "+ pr);
            Console.ReadKey();
        }
    }
}