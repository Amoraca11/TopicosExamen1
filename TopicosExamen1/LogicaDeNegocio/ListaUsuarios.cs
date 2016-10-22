using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDeNegocio
{
    public class ListaUsuarios
    {
        public static ArrayList listaUsuarios = new ArrayList();

        public static void AgregarCarton(Usuario AgregarUsuarios)
        {
            listaUsuarios.Add(AgregarUsuarios);
        }

        public static Usuario getUser(int id)
        {

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                Usuario user = (Usuario)listaUsuarios[i];
                if (user.getID() == id)
                {

                    return user;
                }

            }

            return null;
            MessageBox.Show("No se encontro el carton");
        }
    }
}
