using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaDeNegocio
{
    public class Metodos
    {
        public static void LlenaCartones() {

            int [,] matriz = new int[5, 5];
            Random obj = new Random();
            int[] array = new int[0];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {//apertura for1

                for (int j = 0; j < matriz.GetLength(1); j++)
                {//apertura for interno

                    matriz[i, j] = obj.Next(1, 100);  //asignado valores aleatorios entre 1 y 100

                    while (array.Contains(obj.Next(1,100)))
                    {

                    }

                    

                }//cierre for interno
            }//cierre for1



        }

        public static void AgregaModalidad(string nombre, Carton nuevoCarton) {

        }


    }
}
