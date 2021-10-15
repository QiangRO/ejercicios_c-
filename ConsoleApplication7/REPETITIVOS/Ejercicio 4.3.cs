using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int nt;
            int men=0;
            int cero=0;
            int may=0;
            do
            {
                Console.WriteLine("Digite la cantidad total de numeros");
                nt = int.Parse(Console.ReadLine());

            } while (n <= 0);            
            for(int c=1 ; c<=nt ; c++)
            {
                Console.WriteLine("Digite un numero");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    men++;
                }
                if (n == 0)
                {
                    cero++;
                }
                if (n > 0)
                {
                    may++;
                }
            }
            Console.WriteLine("Hay " + men + " numeros menores a cero");
            Console.WriteLine("Hay " + cero + " numeros cero");
            Console.WriteLine("Hay " + may + " numeros mayores a cero");
            Console.ReadKey();
        }
    }
}
