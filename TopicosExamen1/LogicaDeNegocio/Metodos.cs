using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
