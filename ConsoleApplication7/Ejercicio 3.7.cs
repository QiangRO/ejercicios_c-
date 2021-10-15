using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio37
{
    class Program
    {
        public static void ejercicio()
        {
            int ea;
            int p;
            int d;
            Console.WriteLine("introducir edad del alumno");
            ea = int.Parse(Console.ReadLine());
            Console.WriteLine("introducir promedio");
            p = int.Parse(Console.ReadLine());
            if (ea > 18 && p >= 9)
            {
                d = 2000;
                Console.WriteLine("cuanto deinero recibira por su beca" + d);
            }
            else
            {
                if (p >= 7.5)
                {
                    d = 1000;
                    Console.WriteLine("cuanto deinero recibira por su beca" + d);
                }
                else
                {
                    if (p >= 6)
                    {
                        d = 500;
                        Console.WriteLine("cuanto deinero recibira por su beca" + d);
                    }
                    else
                    {
                        Console.WriteLine("carta de invitacion");
                    }
                }
            }
            if (ea < 18 && p >= 9)
            {
                d = 3000;
                Console.WriteLine("cuanto deinero recibira por su beca" + d);
            }
            else
            {
                if (p < 9 && p >= 8)
                {
                    d = 2000;
                    Console.WriteLine("cuanto deinero recibira por su beca" + d);
                }
                else
                {
                    if (p < 8 && p >= 6)
                    {
                        d = 100;
                        Console.WriteLine("cuanto deinero recibira por su beca" + d);
                    }
                    else
                    {
                        Console.WriteLine("carta de invitacion");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}