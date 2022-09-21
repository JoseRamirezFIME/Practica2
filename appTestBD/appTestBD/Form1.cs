using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTestBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }
            private void button1_Click(object sender, EventArgs e)
            {
                int registros = 0;
                Conexion.EjecutaConsulta(textBox1.Text);
                AccionesComunes.Mensaje("" + registros);
            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            AccionesComunes.LlenarCombo(textBox1.Text, comboBox1, "id", "Nombres");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedValue .ToString();  
        }
    }
}
