using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
         int s;
         int ht;
         int ph;
         int ss;
         int au;

            Console.WriteLine("horas trabajadas");
            ht = int.Parse(Console.ReadLine());
            Console.WriteLine("pago por hora");
            ph = int.Parse(Console.ReadLine());
            if (ht >= 40)
            {
                s = ht * ph;
                au = ht * ph;
                ss = s + au;
            }
            else
            {
                s = ht * ph;
                ss = s;
            }
            Console.WriteLine("MI SUELDO FINAL ES: " + ss);
            Console.ReadKey();
        }
    }
}