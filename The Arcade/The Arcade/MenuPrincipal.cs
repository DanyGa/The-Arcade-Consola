using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Arcade
{
    class MenuPrincipal
    {
        public void Inicio()
        {
            int opcion;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("||========================================================||");
            Console.WriteLine("||--------------------------------------------------------||");

            Console.Write("||----------------- ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("WELCOME TO THE ARCADE");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" ----------------||");

            Console.Write("||------------------- ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Console C# version");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" -----------------||");
            Console.WriteLine("||========================================================||");


            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("                     EL AHORCADO - 1                  ");
            Console.WriteLine("                     QUE NUMERO? - 2                  ");
            Console.WriteLine("                     SALIR - 3                  ");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("||========================================================||");
            Console.WriteLine("||--------------------------------------------------------||");
            Console.WriteLine("||--------------------------------------------------------||");
            Console.WriteLine("||--------------------------------------------------------||");
            Console.WriteLine("||========================================================||");

            opcion = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            switch (opcion)
            {
                case 1:
                    El_ahorcado.Juego1 Ahorcado = new El_ahorcado.Juego1();
                    Ahorcado.Empieza();
                    break;

                case 2:
                    Que_numero.Juego2 Numero = new Que_numero.Juego2();
                    Numero.Start();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

            } while (opcion != 4) ;
        }
    }
}
