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
    public partial class MixedProduct3x3 : Form
    {
        public MixedProduct3x3()
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
                //vector 2
                int ui = int.Parse(textBox1.Text);
                int uj = int.Parse(textBox2.Text);
                int uk = int.Parse(textBox6.Text);
                //vector 3
                int vi = int.Parse(textBox3.Text);
                int vj = int.Parse(textBox4.Text);
                int vk = int.Parse(textBox5.Text);

                int iv = (uj * vk - uk * vj);
                int jv = -(ui * vk - uk * vi);
                int kv = (ui * vj - uj * vi);

                label3.Text = $"Resultado del producto cruz AxB es:  {iv} i,  {jv} j,  {kv} k";

                //vector 1
                int wi = int.Parse(textBox9.Text);
                int wj = int.Parse(textBox8.Text);
                int wk = int.Parse(textBox7.Text);

                int v = (iv * wi) + (jv * wj) + (kv * wk);

                label14.Text = $"Resultado del producto punto es: {v}";
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
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


                int iv = (uj * vk - uk * vj);
                int jv = -(ui * vk - uk * vi);
                int kv = (ui * vj - uj * vi);

                int x, y;
                x = 0;
                y = 0;
                Button butSolve = new Button();
                butSolve.Location = new System.Drawing.Point(x + 90, y + 500);
                butSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                butSolve.Name = "btnRegresar";
                butSolve.Text = "Resgresar";
                butSolve.AutoSize = true;
                Controls.Add(butSolve);
                butSolve.Click += new System.EventHandler(this.butSolve_Click);

                Label lb = new Label();
                this.Size = new System.Drawing.Size(650, 600);
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Text = "Primer paso definimos los valores " +
                "\nB = [ x1 (i), y1 (j), z1 (k) ] y C = [ x2 (i), y2 (j), z2 (k) ]" +
                "\n\n\nTendriamos como resultado " +
                "\nB = [ x1 (" + ui + "i), y1 (" + uj + "j), z1 (" + uk + "k) ] y C = [ x2 (" + vi + "i), y2 ( " + vj + "j), x2 (" + vk + "k) ] " +
                "\n\n\nHaciendo uso de la formula que es " +
                "\nBxC = [ ( y1 * z2 - z1 * y2 ) i , - ( x1 * z2 - z1 * x2) j , + ( x1 * y2 - y1 * x2 ) k ]" +
                "\n\n\nCambiando los valores de las variables por los valores reales tenemos como resultado " +
                "\n BxC = [ ( " + uj + " * " + vk + " - " + uk + " * " + vj + " ) i , - ( " + ui + " * " + vk + " - " + uk + " * " + vi + ") j, + ( " + ui + " * " + vj + " - " + uj + " * " + vi + " ) k ] " +
                "\n\n\nresolvemos las multiplicaciones y obtenemos como resultado " +
                "\nBxC = [ ( " + (uj * vk) + " - " + (uk * vj) + " ) i , - ( " + (ui * vk) + " - " + (uk * vi) + ") j, + ( " + (ui * vj) + " - " + (uj * vi) + " ) k ] " +
                "\n\n\nResolviendo la operacion tendriamos como resultado " +
                "\nBxC = [ " + iv + "i, " + jv + "j, " + kv + "k ]";
                lb.AutoSize = true;
                lb.Location = new System.Drawing.Point(x + 10, y + 18);
                Controls.Add(lb);
            }
        }
        private void butSolve_Click(object sender, EventArgs e)
        {
            MixedProduct3x3 mp = new MixedProduct3x3();
            mp.Visible = true;
            this.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Necesitas llenar todas las casillas");
            }
            else
            {
                Controls.Clear();

                //vector 2
                int ui = int.Parse(textBox1.Text);
                int uj = int.Parse(textBox2.Text);
                int uk = int.Parse(textBox6.Text);
                //vector 3
                int vi = int.Parse(textBox3.Text);
                int vj = int.Parse(textBox4.Text);
                int vk = int.Parse(textBox5.Text);

                int iv = (uj * vk - uk * vj);
                int jv = -(ui * vk - uk * vi);
                int kv = (ui * vj - uj * vi);

                //vector 1
                int wi = int.Parse(textBox9.Text);
                int wj = int.Parse(textBox8.Text);
                int wk = int.Parse(textBox7.Text);

                int v = (iv * wi) + (jv * wj) + (kv * wk);

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
                "\nA = [ x1 (i), y1 (j), z1 (k) ] y (BxC) = [ x2 (i), y2 (j), z2 (k) ]" +
                "\n\n\nTendriamos como resultado " +
                "\nA = [ x1 ( " + wi + "i ), y1 ( " + wj + "j ), z1 ( " + wk + "k ) ] y (BxC) = [ x2 ( " + iv + "i ), y2 ( " + jv + "j ), x2 ( " + kv + "k ) ] " +
                "\n\n\nHaciendo uso de la formula que es " +
                "\nA*(BxC) = [ ( x1 * x2 ) + ( y1 * y2 ) + ( z1 * z2 ) ]" +
                "\n\n\nCambiando los valores de las variables por los valores reales tenemos como resultado " +
                "\n A*(BxC) = [ ( " + wi + " * " + iv + " ) + ( " + wj + " * " + jv + " ) + ( " + wk + " * " + kv + " ) ]" +
                "\n\n\nResolviendo la operacion tendriamos como resultado " +
                "\nA*(BxC) =  [ " + v + " ]";
                lb.AutoSize = true;
                lb.Location = new System.Drawing.Point(x + 10, y + 18);
                Controls.Add(lb);
            }
        }
    }
}
