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

            ControlID.TextData = txtPrimerNum.Text;
            ControlID1.TextData1 = txtSegundoNum.Text;
        }
    }
}
