using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio51
{
    class Program
    {
        public static void ejercicio()
        {
            int j;
            byte p;
            int x;
            int[] alm = new int[6];
            int[] ped = new int[6];
            int[] c = new int[6];

            Console.WriteLine("Proceso de llenado del stock inicial.");
            for (j=0;j<6;j++)
            {
                do
                {
                    Console.WriteLine("Registre la cantidad del producto " + j + " de almacen entre 1 y 100");
                    alm[j] = int.Parse(Console.ReadLine());
                }
                
                while (alm[j] <= 0 || alm[j] > 100);

            }
            Console.Clear();
            do
            {
                Console.WriteLine("¿Que numero de producto desea?           6=SALIR");
                p = byte.Parse(Console.ReadLine());

                if (p >= 0 && p < 6)
                {
                    do
                    {
                        Console.WriteLine("cuantas unidades desea?");
                        x = int.Parse(Console.ReadLine());
                    }
                    
                    while (x <= 0 || x > 100);
                    Console.Clear();
                    ped[p] = x;
                    if (alm[p] == ped[p])
                    {
                        c[p] = alm[p];
                        Console.WriteLine("compra exitosa");
                        Console.WriteLine("debe reabastecer el producto "+p+" con "  + c[p]+" unidades");
                    }
                    else
                    {
                        if (ped[p] > alm[p])
                        {
                            c[p] = 2 * (ped[p] - alm[p]);
                            Console.WriteLine("debe reabastecer el producto " + p + " con " + c[p] + " unidades");
                            Console.WriteLine("compra exitosa");
                        }
                        else
                        {
                            c[p] = ped[p];
                            Console.WriteLine("compra exitosa");
                            Console.WriteLine("debe reabastecer el producto " + p + " con " + c[p] + " unidades");
                        }
                    }
                    alm[p] = alm[p] - ped[p] + c[p];
                }
                else
                {
                    Console.WriteLine("Gracias vuelva pronto");
                }
                Console.ReadKey();
                Console.Clear();
               
            }
            while (p >= 0 && p < 6);
        }
    }
}
