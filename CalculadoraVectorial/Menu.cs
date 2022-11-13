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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CalculatorVectors cv = new CalculatorVectors();
            cv.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addition2x2 add = new Addition2x2();
            add.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addition3x3 add = new Addition3x3();
            add.Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addition2x3 add = new Addition2x3();
            add.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addition3x2 add = new Addition3x2();
            add.Visible = true;
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Subtraction2x2 sub = new Subtraction2x2();
            sub.Visible = true;
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Subtraction2x3 sub = new Subtraction2x3();
            sub.Visible = true;
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductPoint2x2 pp = new ProductPoint2x2();
            pp.Visible = true;
            this.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ProductPoint2x3 pp = new ProductPoint2x3();
            pp.Visible = true;
            this.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ProductPoint3x3 pp = new ProductPoint3x3();
            pp.Visible = true;
            this.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ProductPoint3x2 pp = new ProductPoint3x2();
            pp.Visible = true;
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CrossProduct2x2 cp = new CrossProduct2x2();
            cp.Visible = true;
            this.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CrossProduct2x3 cp = new CrossProduct2x3();
            cp.Visible = true;
            this.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MixedProduct3x3 mp = new MixedProduct3x3();
            mp.Visible = true;
            this.Visible = false;
        }
    }
}
