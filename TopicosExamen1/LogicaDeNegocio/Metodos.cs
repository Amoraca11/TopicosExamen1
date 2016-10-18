using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaDeNegocio{


    public class Metodos{

        public static void LlenaCartones() {

            int [,] matriz = new int[5, 5];
            Random obj = new Random();
            int[] array = new int[30];
            int cont = 0;

            for (int i = 0; i < matriz.GetLength(0); i++){//apertura for1

                for (int j = 0; j < matriz.GetLength(1); j++) {//apertura for interno
                    int numerorandom = obj.Next(1, 100);

                    if (array.Contains(numerorandom)) {

                        numerorandom = obj.Next(1, 100);

                    }  //if
                   
                    else{

                        matriz[i, j] = numerorandom;//asignado valores aleatorios entre 1 y 100
                        array[cont]= numerorandom;
                        cont++;
                    }




                    }//cierre for interno
            }//cierre for1



        }


    }
}
