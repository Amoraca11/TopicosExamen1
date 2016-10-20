using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TopicosExamen1.SolitaDatos;
using static TopicosExamen1.MenuInicio;

namespace TopicosExamen1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            SolitaDatos frm = new SolitaDatos();
            frm.Show();
        }

        private DataGridViewTextBoxColumn setDGVTextColumn(int letterIndex)
        {
            String letter = "";
            if
            (letterIndex == 0) letter = "B";
            else
            if (letterIndex == 1) letter = "I";
            else
            if (letterIndex == 2) letter = "N";
            else
            if (letterIndex == 3) letter = "G";
            else
            if (letterIndex == 4) letter = "O";

            DataGridViewTextBoxColumn columnHeader = new DataGridViewTextBoxColumn();
            columnHeader.HeaderText = letter;
            columnHeader.Name = "Letter" + letter;
            columnHeader.ReadOnly = true;
            return columnHeader;
        }

        private void CreateGrid()
        {

            DataGridView vista = new DataGridView();

            vista.AllowUserToAddRows = false;
            vista.AllowUserToDeleteRows = false;
            vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                setDGVTextColumn(0), setDGVTextColumn(1),setDGVTextColumn(2),setDGVTextColumn(3),setDGVTextColumn(4),});
            vista.Location = new System.Drawing.Point(420, 30);
            vista.Name = "gvUserBoard";
            vista.ReadOnly = true;
            vista.Size = new System.Drawing.Size(380, 300);
            vista.TabIndex = 0;
            vista.RowHeadersVisible = false;

            int B = 1, I = 6, N = 11, G = 16, O = 21;

            for (int p = 0; p < 5; p++)
            {
                string[] row = new string[] { B.ToString(), I.ToString(), N.ToString(), G.ToString(), O.ToString() };
                vista.Rows.Add(row);
                B++; I++; N++; G++; O++;
            }

            int[,] bingMatriz = new int[5,5];
            bingMatriz[0, 0] = 0;
            vista.Rows[2].Cells[2].Value = "BINGO";

            LogicaDeNegocio.Metodos.CartonLetraR(vista);

            //vista.RowTemplate.MinimumHeight = 175

            foreach (DataGridViewRow row in vista.Rows)
            {
                row.Height = 55;
            }

            for (int a = 0; a < 5; a++)
            {
                DataGridViewColumn column = vista.Columns[a];
                column.Width = 75;
                vista.Columns[a].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                vista.Columns[a].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }



            tabPage2.Controls.Add(vista);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LogicaDeNegocio.Metodos.LlenaCartones();
            //CreateGrid();
            //listNumbers.Items.Clear();
            string text = TopicosExamen1.MenuInicio.ControlID.TextData;
            string text1 = TopicosExamen1.MenuInicio.ControlID1.TextData1;
            int primerNum = int.Parse(text);
            int segundoNum = int.Parse(text1);
            listNumbers.Items.Add(LogicaDeNegocio.Metodos.SacaNumeros(primerNum, segundoNum));
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabModalidad.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string[] arreglo = { txt00.Text, txt01.Text,txt02.Text,txt03.Text,txt04.Text,txt10.Text
                    ,txt11.Text,txt12.Text,txt13.Text,txt14.Text,txt20.Text,txt21.Text,txt22.Text,txt23.Text
                    ,txt24.Text,txt30.Text,txt31.Text,txt32.Text,txt33.Text,txt34.Text,txt40.Text,txt41.Text
                    ,txt42.Text,txt43.Text,txt44.Text};
             
            LogicaDeNegocio.Metodos.AgregaModalidad(txtNombreModalidad.Text, arreglo );

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            string text = TopicosExamen1.MenuInicio.ControlID.TextData;
            string text1 = TopicosExamen1.MenuInicio.ControlID1.TextData1;
            int primerNum = int.Parse(text);
            int segundoNum = int.Parse(text1);
            
            LogicaDeNegocio.Metodos.AcomodaNum(primerNum,segundoNum);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
