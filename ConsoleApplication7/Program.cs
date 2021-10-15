using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio22;
using ejercicio24;
using ejercicio26;
using ejercicio28;
using ejercicio210;
using ejercicio216;
using ejercicio218;
using ejercicio222;
using ejercicio31;
using ejercicio32;
using ejercicio36;
using ejercicio37;
using ejercicio39;
using ejercicio314;
using ejercicio316;
using ejercicio318;
using ejercicio42;
using ejercicio43;
using ejercicio45;
using ejercicio48;
using ejercicio49;
using ejercicio410;
using ejercicio416;
using ejercicio417;
using ejercicio51;
using ejercicio52;
using ejercicio53;
using ejercicio54;
using ejercicio55;
using ejercicio56;
using ejercicio57;
using ejercicio58;
using ejercicio59;
using ejercicio510;

namespace PROGRAMACION
{
    public class Program
    {

        public static void menuinicio()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bienvenido a COntenido de Programacion");
            Console.WriteLine("Presione una de las opciones para ingresar al contenido escogido");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("                                                                ");
            Console.WriteLine("1) Ejercicios Selectivos");
            Console.WriteLine("2) Ejercicios Secuenciales");
            Console.WriteLine("3) Ejercicios Repetitivos");
            Console.WriteLine("4) Ejercicios Vectoriales");
            Console.WriteLine("________________________________________________________________");


        }
        public static void menuselectiva()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Presione una de las opciones para ingresar al contenido escogido");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("                                                                ");
            Console.WriteLine("1) Ejercicio 2.2");
            Console.WriteLine("2) Ejercicio 2.4");
            Console.WriteLine("3) Ejercicio 2.6");
            Console.WriteLine("4) Ejercicio 2.8");
            Console.WriteLine("5) Ejercicio 2.10");
            Console.WriteLine("6) Ejercicio 2.16");
            Console.WriteLine("7) Ejercicio 2.18");
            Console.WriteLine("8) Ejercicio 2.22");
            Console.WriteLine("________________________________________________________________");

        }
        public static void menusecuencial()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Presione una de las opciones para ingresar al contenido escogido");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("                                                                ");
            Console.WriteLine("1) Ejercicio 3.1");
            Console.WriteLine("2) Ejercicio 3.2");
            Console.WriteLine("3) Ejercicio 3.6");
            Console.WriteLine("4) Ejercicio 3.7");
            Console.WriteLine("5) Ejercicio 3.9");
            Console.WriteLine("6) Ejercicio 3.14");
            Console.WriteLine("7) Ejercicio 3.16");
            Console.WriteLine("8) Ejercicio 3.18");
            Console.WriteLine("________________________________________________________________");

        }

        public static void menurepetitivas()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Presione una de las opciones para ingresar al contenido escogido");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("                                                                ");
            Console.WriteLine("1) Ejercicio 4.2");
            Console.WriteLine("2) Ejercicio 4.3");
            Console.WriteLine("3) Ejercicio 4.5");
            Console.WriteLine("4) Ejercicio 4.8");
            Console.WriteLine("5) Ejercicio 4.9");
            Console.WriteLine("6) Ejercicio 4.10");
            Console.WriteLine("7) Ejercicio 4.16");
            Console.WriteLine("8) Ejercicio 4.17");
            Console.WriteLine("________________________________________________________________");

        }
        public static void menuvectores()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Presione una de las opciones para ingresar al contenido escogido");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("                                                                ");
            Console.WriteLine("1) Ejercicio 5.1");
            Console.WriteLine("2) Ejercicio 5.2");
            Console.WriteLine("3) Ejercicio 5.3");
            Console.WriteLine("3) Ejercicio 5.4");
            Console.WriteLine("3) Ejercicio 5.5");
            Console.WriteLine("3) Ejercicio 5.6");
            Console.WriteLine("3) Ejercicio 5.7");
            Console.WriteLine("3) Ejercicio 5.8");
            Console.WriteLine("3) Ejercicio 5.9");
            Console.WriteLine("3) Ejercicio 5.10");
            Console.WriteLine("________________________________________________________________");

        }

        public static void Main(string[] args)
        {
            int Opcion;
            int Opcion2, Opcion3, Opcion4, Opcion5;
            do
            {
                Program.menuinicio();
                Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1: Program.menuselectiva();

                        Opcion2 = int.Parse(Console.ReadLine());
                        switch (Opcion2)
                        {
                            case 1: Console.WriteLine("Ejecutando Opcion 1");
                                ejercicio22.Program.ejercicio(); break;
                            case 2: Console.WriteLine("Ejecutando Opcion 2");
                                ejercicio24.Program.ejercicio(); break;
                            case 3: Console.WriteLine("Ejecutando Opcion 3");
                                ejercicio26.Program.ejercicio(); break;
                            case 4: Console.WriteLine("Ejecutando Opcion 4");
                                ejercicio28.Program.ejercicio(); break;
                            case 5: Console.WriteLine("Ejecutando Opcion 5");
                                ejercicio210.Program.ejercicio(); break;
                            case 6: Console.WriteLine("Ejecutando Opcion 6");
                                ejercicio216.Program.ejercicio(); break;
                            case 7: Console.WriteLine("Ejecutando Opcion 7");
                                ejercicio218.Program.ejercicio(); break;
                            case 8: Console.WriteLine("Ejecutando Opcion 8");
                                ejercicio222.Program.ejercicio(); break;

                        }
                        break;
                    case 2: Program.menusecuencial();

                        Opcion3 = int.Parse(Console.ReadLine());
                        switch (Opcion3)
                        {
                            case 1: Console.WriteLine("Ejecutando Opcion 1");
                                ejercicio31.Program.ejercicio(); break;
                            case 2: Console.WriteLine("Ejecutando Opcion 2");
                                ejercicio32.Program.ejercicio(); break;
                            case 3: Console.WriteLine("Ejecutando Opcion 3");
                                ejercicio36.Program.ejercicio(); break;
                            case 4: Console.WriteLine("Ejecutando Opcion 4");
                                ejercicio37.Program.ejercicio(); break;
                            case 5: Console.WriteLine("Ejecutando Opcion 5");
                                ejercicio39.Program.ejercicio(); break;
                            case 6: Console.WriteLine("Ejecutando Opcion 6");
                                ejercicio314.Program.ejercicio(); break;
                            case 7: Console.WriteLine("Ejecutando Opcion 7");
                                ejercicio316.Program.ejercicio(); break;
                            case 8: Console.WriteLine("Ejecutando Opcion 8");
                                ejercicio318.Program.ejercicio(); break;
                        }
                        break;
                    case 3: Program.menurepetitivas();

                        Opcion4 = int.Parse(Console.ReadLine());
                        switch (Opcion4)
                        {
                            case 1: Console.WriteLine("Ejecutando Opcion 1");
                                ejercicio42.Program.ejercicio(); break;
                            case 2: Console.WriteLine("Ejecutando Opcion 2");
                                ejercicio43.Program.ejercicio(); break;
                            case 3: Console.WriteLine("Ejecutando Opcion 3");
                                ejercicio45.Program.ejercicio(); break;
                            case 4: Console.WriteLine("Ejecutando Opcion 4");
                                ejercicio48.Program.ejercicio(); break;
                            case 5: Console.WriteLine("Ejecutando Opcion 5");
                                ejercicio49.Program.ejercicio(); break;
                            case 6: Console.WriteLine("Ejecutando Opcion 6");
                                ejercicio410.Program.ejercicio(); break;
                            case 7: Console.WriteLine("Ejecutando Opcion 7");
                                ejercicio416.Program.ejercicio(); break;
                            case 8: Console.WriteLine("Ejecutando Opcion 8");
                                ejercicio417.Program.ejercicio(); break;
                        }
                        break;
                    case 4: Program.menuvectores();

                        Opcion5 = int.Parse(Console.ReadLine());
                        switch (Opcion5)
                        {
                            case 1: Console.WriteLine("Ejecutando Opcion 1");
                                ejercicio51.Program.ejercicio(); break;
                            case 2: Console.WriteLine("Ejecutando Opcion 2");
                                ejercicio52.Program.ejercicio(); break;
                            case 3: Console.WriteLine("Ejecutando Opcion 3");
                                ejercicio53.Program.ejercicio(); break;
                            case 4: Console.WriteLine("Ejecutando Opcion 4");
                                ejercicio54.Program.ejercicio(); break;
                            case 5: Console.WriteLine("Ejecutando Opcion 5");
                                ejercicio55.Program.ejercicio(); break;
                            case 6: Console.WriteLine("Ejecutando Opcion 6");
                                ejercicio56.Program.ejercicio(); break;
                            case 7: Console.WriteLine("Ejecutando Opcion 7");
                                ejercicio57.Program.ejercicio(); break;
                            case 8: Console.WriteLine("Ejecutando Opcion 8");
                                ejercicio58.Program.ejercicio(); break;
                            case 9: Console.WriteLine("Ejecutando Opcion 8");
                                ejercicio59.Program.ejercicio(); break;
                            case 10: Console.WriteLine("Ejecutando Opcion 8");
                                ejercicio510.Program.ejercicio(); break;
                        }
                        break;
                    default: Program.menuinicio(); break;
                }
            }
            while (Opcion > 0);
            Console.ReadKey();
        }
    }
}
