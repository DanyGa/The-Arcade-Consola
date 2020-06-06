using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Arcade.El_ahorcado
{
    class Juego1 : IAhorcado
    {
        public void Empieza()
        {
            Console.Clear();
            IAhorcado obj = new Juego1();

            int intentos = 0, Ganar = 0;
            string palabra = obj.ElegirPalabra();
            char[] palabraChar = palabra.ToCharArray();
            char[] longitud = obj.GenerarEspacios(palabra);
            string letraingresa = string.Empty;
            char letraingresachar = ' ';

            bool gano = false;

            while (gano == false)
            {
                int SoloUna = 0, contador = 0, repite = 0;

                while (SoloUna == 0)
                {
                    ImprimirHorca(intentos);
                    obj.ImprimirEspacios(longitud);

                    Console.WriteLine("\nHas Fallado: {0}", intentos);
                    Console.Write("\nIntroduce una letra: ");
                    letraingresa = Console.ReadLine();
                    if (obj.CompruebaUna(letraingresa))
                    {
                        letraingresachar = Convert.ToChar(letraingresa);
                        SoloUna++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("Oye, Ingresa solo una letra.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                for (int k = 0; k < longitud.Length; k++)
                {
                    if (longitud[k] == letraingresachar)
                    {
                        if (repite == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Oye, Letra ya encontrada, escribe otra.");
                            Console.ReadKey();
                            repite++;
                        }
                        contador++;
                    }
                    else
                    {
                        if (letraingresachar == palabraChar[k])
                        {
                            longitud[k] = letraingresachar;
                            contador++;
                            Ganar++;
                        }
                    }
                }
                if (contador == 0)
                {
                    intentos++;
                }
                if (intentos == 10)
                {
                    Console.Clear();
                    ImprimirHorca(intentos);
                    Console.WriteLine("\nYa no hay intentos\nPerdiste...");
                    Console.ReadKey();
                    break;
                }
                if (Ganar == palabraChar.Length)
                {
                    gano = true;
                }
                Console.Clear();

            }
            obj.ImprimirFinJuego(palabra, intentos, gano);
            Console.ReadLine();
            AbrirMenu();
        }

        string IAhorcado.ElegirPalabra()
        {
            Random rdn = new Random();
            int n = rdn.Next(0, 4);

            string[] palabras = { "bts", "paseme", "staneabts", "hola", "kiwideharry", "Hola Mundo", "Ramen" };
            string encontrada;

            encontrada = palabras[n];
            return encontrada;
        }

        char[] IAhorcado.GenerarEspacios(string palabra)
        {
            char[] longitud = palabra.ToCharArray();

            for (int a = 0; a < palabra.Length; a++)
                longitud[a] = '_';

            return longitud;
        }

        void IAhorcado.ImprimirEspacios(char[] longitud)
        {
            Console.WriteLine();

            for (int i = 0; i < longitud.Length; i++)
                Console.Write(longitud[i] + " ");

            Console.WriteLine();
        }

        bool IAhorcado.CompruebaUna(string letra)
        {
            bool UnaLetra = false;

            if (letra.Length == 1)
                UnaLetra = true;

            return UnaLetra;
        }

        void IAhorcado.ImprimirFinJuego(string palabra, int intentos, bool gano)
        {
            if (gano == true)
            {
                ImprimirHorca(intentos);
                Console.WriteLine();
                Console.WriteLine("Felicidades lo lograste...!");
                Console.WriteLine();
                Console.WriteLine("La palabra era: {0}", palabra.ToUpper());
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("La palabra era: {0}", palabra.ToUpper());
                Console.ReadKey();
            }
        }

        void ImprimirHorca(int intentos)
        {
            Console.WriteLine("_ _ _");
            if (intentos >= 1)
            {
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("_____");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (intentos >= 4)
            {
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("|");
            }
            if (intentos >= 5)
            {
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("O");
            }
            if (intentos >= 6)
            {
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("/");
            }
            if (intentos >= 7)
            {
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("/T");
            }
            if (intentos >= 8)
            {
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("/T\\");
            }
            if (intentos >= 9)
            {
                Console.SetCursorPosition(2, 4);
                Console.WriteLine("/");
            }
            if (intentos >= 10)
            {
                Console.SetCursorPosition(2, 4);
                Console.WriteLine("/ \\");
            }
            for (int i = 1; i < 6; i++)
            {
                if (intentos > 1)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(0, i);
                Console.WriteLine("|");
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (intentos >= 3)
                Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("_____");
            Console.ForegroundColor = ConsoleColor.White;
        }

        void AbrirMenu()
        {
            Console.WriteLine("Has clic en enter para ir al menu principal");
            Console.ReadLine();
            MenuPrincipal open = new MenuPrincipal();
            open.Inicio();
        }
    }
}
