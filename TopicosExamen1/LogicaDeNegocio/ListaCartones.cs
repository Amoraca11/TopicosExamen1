using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDeNegocio
{
   public class ListaCartones
    {

       public static ArrayList listaCartones = new ArrayList();


        public static void AgregarCarton(Carton CartonAgregar) {

            
            listaCartones.Add(CartonAgregar);
            
      
        }

        public static Carton getCarton(int id) {

            for (int i = 0; i < listaCartones.Count; i++)
            {
                Carton carton =(Carton) listaCartones[i];
                if (carton.getID() == id)
                {

                    return carton;
                }
                 
            }

            return null;
            MessageBox.Show("No se encontro el carton");
        }

        public static void ImprimeLista() {

            foreach (var Carton in listaCartones)
            {
                Console.WriteLine("Imprime " + Carton);
            }

        }


        

        public int  idCarton{ get; set; }

    }
}
