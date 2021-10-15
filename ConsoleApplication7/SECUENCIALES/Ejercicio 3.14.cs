using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.Write("Introducir calificaciones: ");
            N = int.Parse(Console.ReadLine());
            if (N == 10)
            {
                Console.WriteLine("Su calificacion es A");
            }
            else
            {
                if (N == 9)
                {
                    Console.WriteLine("Su calificacion es B");
                }
                else
                {
                    if (N == 8)
                    {
                        Console.WriteLine("Su calificacion es C");
                    }
                    else
                    {
                        if (N >= 6)
                        {
                            Console.WriteLine("Su calificacion es D");
                        }
                        else
                        {
                            if (N <= 5)
                            {
                                Console.WriteLine("Su calificacion es F");
                            }
                            else
                            {
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
