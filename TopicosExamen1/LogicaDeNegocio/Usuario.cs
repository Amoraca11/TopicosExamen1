using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
       public Carton carton { get; set; }
        public Usuario(int Id, string nombreU, Carton Nuevocarton)
        {
            id = Id;
            nombre = nombreU;
            carton = Nuevocarton;
        }

        public Usuario()
        {
        }

        public int getID()
        {
            return this.id;
        }

        public void setID(int idNuevo)
        {
            this.id = idNuevo;
        }

        public void setNombre(string Nombre)
        {
            this.nombre = Nombre;
        }

        public string getnombre()
        {
            return this.nombre;
        }

        public Carton Carton()
        {
            return this.carton;
        }

        public void setListaCartones(Carton Carton1)
        {
            this.carton = Carton1;
        }

    }
}
