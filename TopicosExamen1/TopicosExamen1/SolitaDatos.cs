using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TopicosExamen1
{
    public partial class SolitaDatos : Form
    {
        public SolitaDatos()
        {
            InitializeComponent();
        }
        public static class ControlID
        {
            public static string TextData { get; set; }
        }
        public static class ControlID1
        {
            public static string TextData1 { get; set; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string nombre = txtNomUsuario.Text;
            //string CantidadCartones = NumCartones.Value.ToString();
            //int Cartones = int.Parse(CantidadCartones);
            //Metodos obj_Metodos = new Metodos();
            //int id = obj_Metodos.cantidad_Usuarios + 1;
            //obj_Metodos.cantidad_Usuarios = id;
            //string id_Usuario = id.ToString();
            //string[] Usuario = { id_Usuario, nombre };
            //obj_Metodos.Usuarios.Add(Usuario);
            //obj_Metodos.RelacionarCartones(id, Cartones); 
            string nombre = txtNomUsuario.Text;
            int id = 1;
            int cartones = Convert.ToInt32(NumCartones.Value);
            string text = TopicosExamen1.MenuInicio.ControlID.TextData;
            string text1 = TopicosExamen1.MenuInicio.ControlID1.TextData1;
            int primerNum = int.Parse(text);
            int segundoNum = int.Parse(text1);
            int id1 = 1;

            int[,] Carton1 = LogicaDeNegocio.Metodos.AcomodaNum();
            Carton cartonNuevo = new Carton(id, Carton1);
            LogicaDeNegocio.ListaCartones.AgregarCarton(cartonNuevo);
            Usuario user1 = new Usuario(id, nombre, cartonNuevo);
            ListaUsuarios.listaUsuarios.Add(user1);

            MessageBox.Show("Se creo usuario con exito");


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
