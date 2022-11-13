using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraVectorial
{
    public partial class CalculatorVectors : Form
    {
        public CalculatorVectors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                MessageBox.Show("Acceso Correcto");
                Menu men = new Menu();
                men.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecto");
            }

        }
    }
}
