using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDeNegocio{


    public class Metodos {

        public static int[] arrayNumeros = new int[75];
        public static int cont1 = 0;
        public static int Salionum = 0;
        public ArrayList Usuarios = new ArrayList();
        public ArrayList Cartones = new ArrayList();
        public ArrayList UsuariosCartones = new ArrayList();
        public static ArrayList juegos = new ArrayList();
        public static int num1 = 0;
        public static int num2 = 0;
        public static int tipoJuego = 0;
        public int cantidad_Usuarios = 0;
        public int cantidad_Cartones = 0;

        public static void imprimeMatriz(int[,] matrizPrint) {


            for (int i = 0; i < matrizPrint.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPrint.GetLength(0); j++)
                {
                    Console.Write(matrizPrint[i, j].ToString() + " ");
                }
                Console.WriteLine("");
            }
        }

        public static int[,] AcomodaNum()
        {
            /* la X y Y que se debia de recibir por parametro ahora estan declaradas 
            como una variable global para poder acesarlas en cualquier momento */
            int x = num1;
            int y = num2;
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
                valor = x + inicial;
                mas1 = true;


            }
            else
            {
                valor = y / 5;
                inicial = y / 5;
            }


            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(0); j++)
                {
                    int numerorandom = obj.Next(x, valor + 1);
                    if (array.Contains(numerorandom))
                    {

                        numerorandom = obj.Next(x, valor + 1);

                        while (array.Contains(numerorandom))
                        {

                            numerorandom = obj.Next(x, valor + 1);
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
            return matriz;
        }
        public static void LlenaCartones() {

            int[,] matriz = new int[5, 5];
            Random obj = new Random();
            int[] array = new int[30];
            int cont = 0;

            for (int i = 0; i < matriz.GetLength(0); i++) {//apertura for1

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

            if (cont1 < y) {

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
                    //yusef
                    result = "El numero que ha salido es " + numerorandom;// solo esto cambie
                    MessageBox.Show(result);
                    cont1++;
                    Salionum = numerorandom;


                }  //if

                else if (!arrayNumeros.Contains(numerorandom))
                {

                    arrayNumeros[cont1] = numerorandom;
                    // Console.WriteLine("El numero que ha salido es " + numerorandom);
                    result = "El numero que ha salido es " + numerorandom;
                    MessageBox.Show(result);//yusef: solo modifiue este mensaje
                    cont1++;
                    Salionum = numerorandom;
                }



            }
            else { MessageBox.Show("Han salido todos los numeros gracias por jugar"); }

            return result;

        }

        
        /// <summary>
        /// de mommento solo pinta lo que recibo de la matriz
        /// </summary>
        /// <param name="nombre">el nombre que recibira la nueva modalidad</param>
        /// <param name="arreglo">lista de lo que se lleno antes</param>
        public static void AgregaModalidad(string nombre, string[] arreglo)
        {
            byte[,] matriz = new byte[5, 5];

            int cont = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int l = 0; l < 5; l++)
                {

                    if (String.IsNullOrEmpty(arreglo[cont].ToString()))
                        matriz[i, l] = 0;
                    else
                        matriz[i, l] = 1;
                    cont++;
                };
            };
        }
            /// <summary>
            /// Metodo que agrega la nueva modalidad de matriz ya dada ppor defecto
            /// </summary>
            /// <param name="nombre"></param>
            /// <param name="arreglo"></param>
        public static void AgregaModalidadDos(string nombre, byte[,] arreglo)
        {
            TipoJuego modalidad = new TipoJuego(nombre, arreglo);
            juegos.Add(modalidad);
        }

        public static void LlenaJuegos() {
            byte[,] cartonLleno = { { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }
                , {1,1,1,1,1}, {1,1,1,1,1}, { 1,1,1,1,1 } };
            AgregaModalidadDos("Carton Lleno", cartonLleno);
            byte[,] cuatroEsquinas = { { 1, 0, 0, 0, 1 }, { 0,0,0,0,0 }
                , {0,0,1,0,0}, {0,0,0,0,0}, { 1,0,0,0,1 } };
            AgregaModalidadDos("Cuatro Esquinas", cartonLleno);
            byte[,] letraH = { { 1, 0, 0, 0, 1 }, { 1,0,0,0,1 }
                , {1,1,1,1,1}, {1,0,0,0,1}, { 1,0,0,0,1 } };
            AgregaModalidadDos("Letra H", letraH);
            byte[,] letraX = { { 1, 0, 0, 0, 1 }, { 0,1,0,1,0 }
                , {0,0,1,0,0}, {0,1,0,1,0}, { 1,0,0,0,1 } };
            AgregaModalidadDos("Letra X", letraX);
            byte[,] letraO = { { 1, 1,1,1,1 }, { 1,0,0,0,1 }
                , {1,0,1,0,1}, {1,0,0,0,1}, { 1,1,1,1,1 } };
            AgregaModalidadDos("Letra O ", letraO);
            byte[,] letraU = { { 1, 0, 0, 0, 1 }, { 1,0,0,0,1 }
                , {1,0,1,0,1}, {1,0,0,0,1}, { 1,1,1,1,1 } };
            AgregaModalidadDos("Letra U", letraU);
            byte[,] letraP = { { 1, 1,1,1, 1 }, { 1,0,0,0,1 }
                , {1,1,1,1,1}, {1,0,0,0,0}, { 1,0,0,0,0 } };
            AgregaModalidadDos("Letra P", letraP);
            byte[,] letraA = { { 0, 0, 1, 0, 0 }, { 0,1,0,1,0 }
                , {1,1,1,1,1}, {1,0,0,0,1}, { 1,0,0,0,1 } };
            AgregaModalidadDos("Letra A", letraA);
            byte[,] letraE = { { 1, 1,1,1,1}, { 1,0,0,0,0 }
                , {1,1,1,1,1}, {1,0,0,0,0}, { 1,1,1,1,1 } };
            AgregaModalidadDos("Letra E", letraE);
            byte[,] letraW = { { 1, 0, 0, 0, 1 }, { 0,0,0,0,0 }
                , {0,1,1,1,0}, {0,1,0,1,0}, { 0,1,0,1,0 } };
            AgregaModalidadDos("Letra W", letraW);
            byte[,] letraR = { { 1,1,1,1,0 }, { 0,0,0,1,0 }
                , {1,1,1,1,0}, {1,0,0,1,0}, { 1,0,0,0,1 } };
            AgregaModalidadDos("Letra R", letraR);
        }

        public static void AgregaTipo(DataGridView data)
        {
            switch (tipoJuego)
            {
                case 0:
                    CartonLleno(data);
                    break;
                case 1:
                    Carton4Esquinas(data);
                    break;
                case 2:
                    CartonLetraH(data);
                    break;
                case 3:
                    CartonLetraX(data);
                    break;
                case 4:
                    CartonLetraO(data);
                    break;
                case 5:
                    CartonLetraU(data);
                    break;
                case 6:
                    CartonLetraP(data);
                    break;
                case 7:
                    CartonLetraA(data);
                    break;
                case 8:
                    CartonLetraE(data);
                    break;
                case 9:
                    CartonLetraW(data);
                    break;
                case 10:
                    CartonLetraR(data);
                    break;
            } 

        }

        public static void CartonLleno(DataGridView matriz)
        {
            int cont = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz.Rows[i].Cells[j] == matriz.Rows[2].Cells[2])
                    {
                        matriz.Rows[2].Cells[2].Value = "BINGO";
                    }
                    else if ((Int16.Parse(matriz.Rows[i].Cells[j].Value.ToString())) == Salionum)
                    {
                        matriz.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(matriz.Rows[i].Cells[j].Style.ForeColor == Color.Red)
                    {
                        cont++;
                    }
                }
            }

            if(cont == 24)
            {
                MessageBox.Show("Juego terminado");
            }
        }

        public static void Carton4Esquinas(DataGridView matriz)
        {

            if ((Int16.Parse(matriz.Rows[0].Cells[0].Value.ToString())) == Salionum)
            {
                matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[4].Cells[0].Value.ToString())) == Salionum)
            {
                matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[0].Cells[4].Value.ToString())) == Salionum)
            {
                matriz.Rows[0].Cells[4].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[4].Cells[4].Value.ToString())) == Salionum)
            {
                matriz.Rows[4].Cells[4].Style.ForeColor = Color.Red;
            }

            matriz.Rows[2].Cells[2].Value = "BINGO";
        }

        public static void CartonLetraH(DataGridView matriz)
        {
            if ((Int16.Parse(matriz.Rows[0].Cells[0].Value.ToString())) == Salionum)
            {
                matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[1].Cells[0].Value.ToString())) == Salionum)
            {
                matriz.Rows[1].Cells[0].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[2].Cells[0].Value.ToString())) == Salionum)
            {
                matriz.Rows[2].Cells[0].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[3].Cells[0].Value.ToString())) == Salionum)
            {
                matriz.Rows[3].Cells[0].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[4].Cells[0].Value.ToString())) == Salionum)
            {
                matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[1].Cells[4].Value.ToString())) == Salionum)
            {
                matriz.Rows[1].Cells[4].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[2].Cells[4].Value.ToString())) == Salionum)
            {
                matriz.Rows[2].Cells[4].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[3].Cells[4].Value.ToString())) == Salionum)
            {
                matriz.Rows[3].Cells[4].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[4].Cells[4].Value.ToString())) == Salionum)
            {
                matriz.Rows[4].Cells[4].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[2].Cells[1].Value.ToString())) == Salionum)
            {
                matriz.Rows[2].Cells[1].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[2].Cells[3].Value.ToString())) == Salionum)
            {
                matriz.Rows[2].Cells[3].Style.ForeColor = Color.Red;
            }


            matriz.Rows[2].Cells[2].Value = "BINGO";
            matriz.Rows[2].Cells[2].Style.ForeColor = Color.Red;
        }

        public static void CartonLetraX(DataGridView matriz)
        {

            if ((Int16.Parse(matriz.Rows[0].Cells[0].Value.ToString())) == Salionum)
            {
                matriz.Rows[0].Cells[0].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[4].Cells[0].Value.ToString())) == Salionum)
            {
                matriz.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[0].Cells[4].Value.ToString())) == Salionum)
            {
                matriz.Rows[0].Cells[4].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[4].Cells[4].Value.ToString())) == Salionum)
            {
                matriz.Rows[4].Cells[4].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[1].Cells[1].Value.ToString())) == Salionum)
            {
                matriz.Rows[1].Cells[1].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[1].Cells[3].Value.ToString())) == Salionum)
            {
                matriz.Rows[1].Cells[3].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[3].Cells[3].Value.ToString())) == Salionum)
            {
                matriz.Rows[3].Cells[3].Style.ForeColor = Color.Red;
            }
            else if ((Int16.Parse(matriz.Rows[3].Cells[1].Value.ToString())) == Salionum)
            {
                matriz.Rows[3].Cells[1].Style.ForeColor = Color.Red;
            }

            matriz.Rows[2].Cells[2].Value = "BINGO";
            matriz.Rows[2].Cells[2].Style.ForeColor = Color.Red;

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

        public void RelacionarCartones(int id_Usuario, int CantidadCartones)
        {
            for (int i = 0; i <= CantidadCartones; i++)
            {
                Boolean creado = false;
                int[,] matriz;
                while (creado == false)
                {
                    matriz = AcomodaNum();
                    Boolean igual = comparaMatriz(matriz);
                    if(igual == false)
                    {
                        Cartones.Add(matriz);
                        creado = true;
                    }
                }
                int [] UsuarioCarton = { id_Usuario, cantidad_Cartones };
                cantidad_Cartones++;
                UsuariosCartones.Add(UsuarioCarton);
            }
        }

        public Boolean  comparaMatriz(int [,]  matrizNueva) {

            bool igual = true;
            if (Cartones.Count == 0)
            {
                igual = false;
            }
            else {
                foreach(int [,] martrizVieja in Cartones)
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        for(int k = 0; k <= 4; k++)
                        {
                            if(matrizNueva[j,k] != martrizVieja[j, k])
                            {
                                igual = false;
                            }
                        }
                    }
                }

            }
            return igual;
        }

    }
}
