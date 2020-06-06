using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Arcade.Que_numero
{
    class Juego2 : IQueNumero
    {
        public void Abrir()
        {
            Console.WriteLine("Has clic en enter para ir al menu principal");
            Console.ReadLine();
            MenuPrincipal open = new MenuPrincipal();
            open.Inicio();
        }

        public void Start()
        {
            Console.Clear();
            int Min = 1, Max = 51;
            Console.Title = "QUE NUMERO?";
            Console.WriteLine("Bienvenido a Que numero?! \n\n Voy a pensar un numero del " + Min + " al " + (Max - 1) + " y debes adivinarlo!");
            Console.Write("Escribe un numero: ");
            Random r = new Random(Guid.NewGuid().GetHashCode());
            int numeroElegido = r.Next(Min, Max);
            int numeroIngresado = 0;

            do
            {
                numeroIngresado = Convert.ToInt32(Console.ReadLine());

                if (numeroIngresado > numeroElegido)
                {
                    Console.WriteLine("Es un numero menor a ese");
                }
                else if (numeroIngresado < numeroElegido)
                {
                    Console.WriteLine(" Es un numero mayor a ese");
                }
                else
                {
                    Console.WriteLine("Ganaste");
                    Console.ReadKey();
                }
            } while (numeroElegido != numeroIngresado);
            Console.ReadLine();
            Abrir();
        }
    }
}
