using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Arcade.El_ahorcado
{
    interface IAhorcado
    {
        string ElegirPalabra();

        char[] GenerarEspacios(string palabra);

        void ImprimirEspacios(char[] longitud);

        bool CompruebaUna(string letra);

        void ImprimirFinJuego(string palabra, int intentos, bool gano);
    }
}
