using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    class ListaUsuarios
    {
        public static ArrayList listaUsuarios = new ArrayList();

        public static void AgregarCarton(Usuario AgregarUsuarios)
        {
            listaUsuarios.Add(AgregarUsuarios);
        }
    }
}
