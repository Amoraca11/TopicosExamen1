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
    public partial class MenuInicio : Form
    {
        public MenuInicio()
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(comboBox1.SelectedItem.ToString());
            int num2 = int.Parse(comboBox2.SelectedItem.ToString());

            if ( num2-num1 >= 28) {
                Principal frm = new Principal();
                frm.Show();
                ControlID.TextData = comboBox1.SelectedItem.ToString();
                ControlID1.TextData1 = comboBox2.SelectedItem.ToString();
            }else
            {
                MessageBox.Show("Los parámetros solicitados no cumplen con las restricciones. Asegúrese que hayan almenos 30 números de diferencia entre cada límite");
            }

        }

    }
}
