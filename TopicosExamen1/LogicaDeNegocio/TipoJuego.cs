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
        }

    }
}
