using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    class TipoJuego
    {
        public string nombreJuego;
        public byte[,] matriz;

        public TipoJuego(string nuevNombre, byte[,] nuevoArreglo) {
            nombreJuego = nuevNombre;
            matriz = nuevoArreglo;
        }
        public TipoJuego()
        {
            nombreJuego = "";
            matriz = new byte[5, 5];
        }
        public static void ImrimeJuego() {
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
               //     var result = matriz[i, j];
                   Console.Write(result );
                }

            }
        }

    }
}
