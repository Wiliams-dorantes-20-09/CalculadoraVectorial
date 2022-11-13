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
    public partial class ProductPoint3x3 : Form
    {
        public ProductPoint3x3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Necesitas llenar todas las casillas");
            }
            else
            {
                //vector 1
                int ui = int.Parse(textBox1.Text);
                int uj = int.Parse(textBox2.Text);
                int uk = int.Parse(textBox6.Text);
                //vector 2
                int vi = int.Parse(textBox3.Text);
                int vj = int.Parse(textBox4.Text);
                int vk = int.Parse(textBox5.Text);
                //vector3
                int wi = int.Parse(textBox9.Text);
                int wj = int.Parse(textBox8.Text);
                int wk = int.Parse(textBox7.Text);

                int v = (ui * vi * wi) + (uj * vj * wj) + (uk * vk * wk);

                label3.Text = $"Resultado del producto punto es: {v}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Necesitas llenar todas las casillas");
            }
            else
            {
                Controls.Clear();

                //vector 1
                int ui = int.Parse(textBox1.Text);
                int uj = int.Parse(textBox2.Text);
                int uk = int.Parse(textBox6.Text);
                //vector 2
                int vi = int.Parse(textBox3.Text);
                int vj = int.Parse(textBox4.Text);
                int vk = int.Parse(textBox5.Text);
                //vector3
                int wi = int.Parse(textBox9.Text);
                int wj = int.Parse(textBox8.Text);
                int wk = int.Parse(textBox7.Text);

                int v = (ui * vi * wi) + (uj * vj * wj) + (uk * vk * wk);

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
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Text = "Primer paso definimos los valores " +
                "\nu = [ x1 (i), y1 (j), z1 (k) ], v = [ x2 (i), y2 (j), z2 (k) ] y w = [ x3 (i), y3 (j), z3 (k) ]" +
                "\n\n\nTendriamos como resultado " +
                "\nu = [ x1 (" + ui + "i), y1 (" + uj + "j), z1 (" + uk + "k) ] y v = [ x2 (" + vi + "i), y2 ( " + vj + "j), z2 (" + vk + "k) ] y w = [ x3 (" + wi + "i), y3 ( " + wj + "j, z3 (" + wk + "k) ]" +
                "\n\n\nHaciendo uso de la formula que es " +
                "\nA*B*C = [ (x1 * x2 * x3) + (y1 * y2 * y3) + (z1 * z2 * z3) ]" +
                "\n\n\nCambiando los valores de las variables por los valores reales tenemos como resultado " +
                "\nA*B*C = [ (" + ui + " * " + vi + " * " + wi + ") + (" + uj + " * " + vj + " * " + wj + ") + (" + uk + " * " + vk + " * " + wk + ") ]" +
                "\n\n\nResolviendo la operacion tendriamos como resultado " +
                "\nA*B*C = [ " + v + " ]";
                lb.AutoSize = true;
                lb.Location = new System.Drawing.Point(x + 10, y + 18);
                Controls.Add(lb);
            }
        }

        private void butSolve_Click(object sender, EventArgs e)
        {
            ProductPoint3x3 pp = new ProductPoint3x3();
            pp.Visible = true;
            this.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }
    }
}
