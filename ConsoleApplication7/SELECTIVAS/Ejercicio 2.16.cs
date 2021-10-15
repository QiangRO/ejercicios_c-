using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2._16
{
    public class Program
    {
        static void Main(string[] args)
        {
            int P;
            string H, Ch, Az, Sal, Ph, Ac, Hu, Ah;
             
            Console.WriteLine("Quieres un pastel ingrese 0");
            P = Convert.ToInt32(Console.ReadLine());

                H = ("Harina, 3 tazas");
                Ch = ("Chocolate en polvo, 1 taza");
                Az = ("Azúcar, 2 tazas");
                Sal = ("Sal, ½ cucharadita");
                Ph = ("Polvo de hornear, 3 cdas");
                Ac = ("Aceite, 1 taza");
                Hu = ("Huevos, 3");
                Ah = ("Agua hirviendo, 2 tazas");
                
            Console.WriteLine(P + "\n" + "\n" + H + "\n" + Ch + "\n" + Az + "\n" + Sal + "\n" + Ph + "\n" + Ac + "\n" + Hu + "\n" + Ah);
            Console.WriteLine();
            Console.WriteLine("Disfrute su pastel !!!!");
            Console.ReadKey();
        }
    }
}
