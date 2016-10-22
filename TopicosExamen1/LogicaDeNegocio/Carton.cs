using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace LogicaDeNegocio
{
    public class Carton
    {
        public int idCarton { get; set; }
        public  int[,] cartonNum { get; set; }

        public Carton(int Id, int[,] cartonCreado)
        {
           idCarton = Id;
            cartonNum = cartonCreado;
        }

        public int getID()
        {
            return this.idCarton;
        }

        public void setID(int idNuevo)
        {
            this.idCarton = idNuevo;
        }
        public int[,] getCarton()
        {
            return this.cartonNum;
        }

        public void setCarton(int[,] CartonNuevo)
        {
            this.cartonNum = CartonNuevo;
        }
        public override bool Equals(object obj)
        {
            Carton other = obj as Carton;

            if (other == null)
            {
                return false;
            }
            return (this.cartonNum == other.cartonNum) &&
                   (this.idCarton != other.idCarton);
        }


    }
}
