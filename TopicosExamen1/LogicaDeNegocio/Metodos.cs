using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDeNegocio{


    public class Metodos{

        public static int[] arrayNumeros = new int[75];
        public static int cont1 = 0;

        public static void imprimeMatriz(int [,] matrizPrint ) {


            for (int i = 0; i < matrizPrint.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPrint.GetLength(0); j++)
                {
                    Console.Write( matrizPrint[i, j].ToString()+" ");
                }
                Console.WriteLine("");
            }
        }

        public static void AcomodaNum( int x, int y)
        {
            int valor;
            int inicial;
            int[,] matriz = new int[5, 5];
            Random obj = new Random();
            int[] array = new int[30];
            int cont = 0;
            int i = 0;
            int j = 0;
            bool mas1 = false;


            if (x != 1)
           {
                inicial = (y - x) / 5;
                valor = x+inicial;
                mas1 = true;
                

            }
            else
            {
                 valor = y / 5;
                 inicial = y / 5;
            }
            

            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for ( j = 0; j < matriz.GetLength(0); j++)
                {
                    int numerorandom = obj.Next(x, valor+1);
                    if (array.Contains(numerorandom))
                    {

                        numerorandom = obj.Next(x,valor+1);

                        while (array.Contains(numerorandom))
                        {

                            numerorandom = obj.Next(x, valor+1);
                        }
                        matriz[j, i] = numerorandom;//asignado valores aleatorios entre 1 y 100
                        array[cont] = numerorandom;
                        cont++;

                    }  //if

                    else if (!array.Contains(numerorandom))
                    {

                        matriz[j, i] = numerorandom;//asignado valores aleatorios entre 1 y 100
                        array[cont] = numerorandom;
                        cont++;
                    }


                }//primerfor

                if (mas1) {

                    x++;
                    mas1 = false;
                }
                x = x + inicial;
                valor = valor + inicial;
             

            }//segundofor
            imprimeMatriz(matriz);
        }
        public static void LlenaCartones() {

            int [,] matriz = new int[5, 5];
            Random obj = new Random();
            int[] array = new int[30];
            int cont = 0;

            for (int i = 0; i < matriz.GetLength(0); i++){//apertura for1

                for (int j = 0; j < matriz.GetLength(1); j++) {//apertura for interno
                    int numerorandom = obj.Next(1, 35);

                    if (array.Contains(numerorandom))
                    {

                        numerorandom = obj.Next(1, 35);
                        while (array.Contains(numerorandom))
                        {

                            numerorandom = obj.Next(1, 35);
                        }
                        matriz[i, j] = numerorandom;//asignado valores aleatorios entre 1 y 100
                        array[cont] = numerorandom;
                        cont++;

                    }  //if

                    else if (!array.Contains(numerorandom))
                    {

                        matriz[i, j] = numerorandom;//asignado valores aleatorios entre 1 y 100
                        array[cont] = numerorandom;
                        cont++;
                    }

                



                    }//cierre for interno
            }//cierre for1



        }
        public static string SacaNumeros(int x, int y)
        {
            string result = "";
            Random obj = new Random();
            // int[] array = new int[y];

            if(cont1< y){ 

            int numerorandom = obj.Next(x, y + 1);

            if (arrayNumeros.Contains(numerorandom))
            {

                numerorandom = obj.Next(x, y + 1);
                while (arrayNumeros.Contains(numerorandom))
                {

                    numerorandom = obj.Next(x, y + 1);
                }
                arrayNumeros[cont1] = numerorandom;
                // Console.WriteLine("El numero que ha salido es " + numerorandom);
                MessageBox.Show("El numero que ha salido es " + numerorandom);
                cont1++;


            }  //if

            else if (!arrayNumeros.Contains(numerorandom))
            {

                arrayNumeros[cont1] = numerorandom;
                // Console.WriteLine("El numero que ha salido es " + numerorandom);
                MessageBox.Show("El numero que ha salido es " + numerorandom);
                cont1++;
            }



        }
            else { MessageBox.Show("Han salido todos los numeros gracias por jugar");  }

            return result;
           
        }

        /// <summary>
        /// agrega una modalidad de juego a los ya puestos en el juego de bingo
        /// </summary>
        /// <param name="nombre">el nombre que recibira la nueva modalidad</param>
        /// <param name="carton">matriz con el machote del nuevo juego</param>
        public static void AgregaModalidad(string nombre, Carton carton)
        {
         
        }

        public static void CartonLleno(DataGridView matriz)
        {
            for(int i = 0; i<5; i++)
            {
                for(int j=0; j < 5; j++)
                {
                    if (matriz.Rows[i].Cells[j]==matriz.Rows[2].Cells[2])
                    {
                        matriz.Rows[2].Cells[2].Value = "BINGO";
                    }
                    else
                    {
                        matriz.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

        public static void Carton4Esquinas(DataGridView matriz)
        {
            matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[4].Style.ForeColor = Color.Red;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz.Rows[i].Cells[j] == matriz.Rows[2].Cells[2])
                    {
                        matriz.Rows[2].Cells[2].Value = "BINGO";
                    }
                }
            }            

        }

        public static void CartonLetraH(DataGridView matriz)
        {
            matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[3].Style.ForeColor = Color.Red;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz.Rows[i].Cells[j] == matriz.Rows[2].Cells[2])
                    {
                        matriz.Rows[2].Cells[2].Value = "BINGO";
                        matriz.Rows[2].Cells[2].Style.ForeColor = Color.Red;
                    }
                }
            }

        }

        public static void CartonLetraX(DataGridView matriz)
        {
            matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[1].Style.ForeColor = Color.Red;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz.Rows[i].Cells[j] == matriz.Rows[2].Cells[2])
                    {
                        matriz.Rows[2].Cells[2].Value = "BINGO";
                        matriz.Rows[2].Cells[2].Style.ForeColor = Color.Red;
                    }
                }
            }

        }

        public static void CartonLetraO(DataGridView matriz)
        {
            matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[2].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[2].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[3].Style.ForeColor = Color.Red;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz.Rows[i].Cells[j] == matriz.Rows[2].Cells[2])
                    {
                        matriz.Rows[2].Cells[2].Value = "BINGO";
                    }
                }
            }

        }

        public static void CartonLetraU(DataGridView matriz)
        {
            matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[2].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[3].Style.ForeColor = Color.Red;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz.Rows[i].Cells[j] == matriz.Rows[2].Cells[2])
                    {
                        matriz.Rows[2].Cells[2].Value = "BINGO";
                    }
                }
            }

        }

        public static void CartonLetraP(DataGridView matriz)
        {
            matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[2].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[1].Style.ForeColor = Color.Red;



            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz.Rows[i].Cells[j] == matriz.Rows[2].Cells[2])
                    {
                        matriz.Rows[2].Cells[2].Value = "BINGO";
                        matriz.Rows[2].Cells[2].Style.ForeColor = Color.Red;
                    }
                }
            }

        }

        public static void CartonLetraA(DataGridView matriz)
        {
            matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[2].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[1].Style.ForeColor = Color.Red;


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz.Rows[i].Cells[j] == matriz.Rows[2].Cells[2])
                    {
                        matriz.Rows[2].Cells[2].Value = "BINGO";
                        matriz.Rows[2].Cells[2].Style.ForeColor = Color.Red;
                    }
                }
            }

        }

        public static void CartonLetraE(DataGridView matriz)
        {
            matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[2].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[2].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[4].Style.ForeColor = Color.Red;


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz.Rows[i].Cells[j] == matriz.Rows[2].Cells[2])
                    {
                        matriz.Rows[2].Cells[2].Value = "BINGO";
                        matriz.Rows[2].Cells[2].Style.ForeColor = Color.Red;
                    }
                }
            }

        }

        public static void CartonLetraW(DataGridView matriz)
        {
            matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[2].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[2].Style.ForeColor = Color.Red;


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz.Rows[i].Cells[j] == matriz.Rows[2].Cells[2])
                    {
                        matriz.Rows[2].Cells[2].Value = "BINGO";
                        matriz.Rows[2].Cells[2].Style.ForeColor = Color.Red;
                    }
                }
            }

        }

        public static void CartonLetraR(DataGridView matriz)
        {
            matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[2].Style.ForeColor = Color.Red;
            matriz.Rows[0].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[1].Cells[4].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[2].Cells[1].Style.ForeColor = Color.Red;
            matriz.Rows[4].Cells[3].Style.ForeColor = Color.Red;
            matriz.Rows[3].Cells[2].Style.ForeColor = Color.Red;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz.Rows[i].Cells[j] == matriz.Rows[2].Cells[2])
                    {
                        matriz.Rows[2].Cells[2].Value = "BINGO";
                        matriz.Rows[2].Cells[2].Style.ForeColor = Color.Red;
                    }
                }
            }

        }

    }
}
