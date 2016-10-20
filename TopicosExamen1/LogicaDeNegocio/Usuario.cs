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
        public int cantidad { get; set; }
        public int[,] cartones { get; set; }

        public Usuario(int Id, string nombreU, int Cantidad, int[,] Numcarton)
        {
            id = Id;
            nombre = nombreU;
            cantidad = Cantidad;
            cartones = Numcarton;
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

        public int getCantidad()
        {
            return this.cantidad;
        }

        public void setcantidad(int Cantidad)
        {
            this.cantidad = Cantidad;
        }

        public int[,] getCartones()
        {
            return this.cartones;
        }

        public void setCarton(int[,] CartonNum)
        {
            this.cartones = CartonNum;
        }

    }
}
