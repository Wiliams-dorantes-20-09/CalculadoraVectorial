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
    public partial class ProductPoint2x2 : Form
    {
        public ProductPoint2x2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Necesitas llenar todas las casillas");
            }
            else
            {
                //vector 1
                int ui = int.Parse(textBox1.Text);
                int uj = int.Parse(textBox2.Text);
                //vector 2
                int vi = int.Parse(textBox3.Text);
                int vj = int.Parse(textBox4.Text);

                int v = (ui * vi) +(uj * vj);

                label3.Text = $"Resultado del peoducto punto es: {v}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Necesitas llenar todas las casillas");
            }
            else
            {
                Controls.Clear();

                //vector 1
                int ui = int.Parse(textBox1.Text);
                int uj = int.Parse(textBox2.Text);
                //vector 2
                int vi = int.Parse(textBox3.Text);
                int vj = int.Parse(textBox4.Text);

                int v = (ui * vi) + (uj * vj);

                int x, y;
                x = 0;
                y = 0;

                Button butSolve = new Button();
                butSolve.Location = new System.Drawing.Point(x + 90, y + 400);
                butSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                butSolve.Name = "btnRegresar";
                butSolve.Text = "Resgresar";
                butSolve.AutoSize = true;
                Controls.Add(butSolve);
                butSolve.Click += new System.EventHandler(this.butSolve_Click);

                Label lb = new Label();
                this.Size = new System.Drawing.Size(650, 490);
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Text = "Primer paso definimos los valores " +
                "\nu = [ x1 (i), y1 (j) ] y v = [ x2 (i), y2 (j) ]" +
                "\n\n\nTendriamos como resultado " +
                "\nu = [ x1 (" + ui + "i), y1 (" + uj + "j) ] y v = [ x2 (" + vi + "i), y2 ( " + vj + "j) ]" +
                "\n\n\nHaciendo uso de la formula que es " +
                "\n A*B = [ (x1 * x2) + (y1 * y2) ]" +
                "\n\n\nCambiando los valores de las variables por los valores reales tenemos como resultado " +
                "\nA*B = [ (" + ui + " * " + vi + ") + (" + uj + " * " + vj + ") ]" +
                "\n\n\nResolviendo la operacion tendriamos como resultado " +
                "\nA*B = [ "+v+" ]";
                lb.AutoSize = true;
                lb.Location = new System.Drawing.Point(x + 10, y + 18);
                Controls.Add(lb);
            }
        }

        private void butSolve_Click(object sender, EventArgs e)
        {
            ProductPoint2x2 pp = new ProductPoint2x2();
            pp.Visible = true;
            this.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Visible = true;
            this.Visible = false;
        }
    }
}
