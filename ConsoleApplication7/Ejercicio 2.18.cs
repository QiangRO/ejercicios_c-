using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio218
{
    class Program
    {
        public static void ejercicio()
        {
            int T;
            string hue, tal, th, cv, ps, olc, olh, tl, m, cl, tac, pps, cdc, cdm, pd, cm, f, Cht;

            Console.WriteLine("Quieres una Torta ingrese 0");
            T = Convert.ToInt32(Console.ReadLine());

            hue = ("4 huevos");
            tal = ("1 taza de azúcar (1 taza de azúcar = 7 onzas = 200 gramos)");
            th = ("1 taza de harina todo uso (1 tasa de harina todo uso = 5 onzas = 140 gramos)");
            cv = ("1 cucharadita de vainilla");
            ps = ("1 pizca de sal");
            olc = ("14 onzas de leche condensada (1 lata de 14 onzas=397 gramos)");
            olh = ("12 onzas de leche evaporada o crema (nata) líquida de leche (1 lata de 12 onzas=355 ml)");
            tl = ("1 taza de leche (1 taza de leche=250 ml)");
            m = ("Para el merengue:");
            cl = ("4 claras de huevo (4 claras de huevo son ~5 onzas)");
            tac = ("1 taza de azúcar (1 taza de azúcar = 7 onzas = 200 gramos)");
            pps = ("1 pizca de sal");
            cdc = ("1/4 cucharadita de cremor tártaro - se puede reemplazar con unas gotitas de jugo de limón");
            cdm = ("2 cucharadas de canela molida");
            pd = ("Ideas para decorar:");
            cm = ("Canela molida");
            f = ("Fresas o frutillas, cerezas, durazno, mango");
            Cht = ("Chocolate");
            Console.WriteLine();
            Console.WriteLine(hue + "\n" + tal + "\n" + th + "\n" + cv + "\n" + ps + "\n" + olc + "\n" + olh + "\n" + tl + "\n" + m + "\n" + cl + "\n" + tac + "\n" + pps + "\n" + cdc + "\n" + cdm + "\n" + pd + "\n" + cm + "\n" + f + "\n" + Cht);
            Console.WriteLine();
            Console.WriteLine("Disfrute su Torta !!!!");
            Console.ReadKey();
        }
    }
}
