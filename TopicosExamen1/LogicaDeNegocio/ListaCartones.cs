using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LogicaDeNegocio
{
    class ListaCartones
    {

       public static ArrayList listaCartones = new ArrayList();


        public static void AgregarCarton(Carton CartonAgregar) {

            
            listaCartones.Add(CartonAgregar);
             
   

        }

        public static void ImprimeLista() {

            foreach (var item in listaCartones)
            {
                Console.WriteLine("Imprime " + item);
            }

        }
        

        public int idUsuario { get; set; }

        public int  idCarton{ get; set; }

    }
}
