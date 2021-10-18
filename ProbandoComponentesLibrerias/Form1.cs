using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbandoComponentesLibrerias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(500, 500);
            this.CenterToScreen();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (rbTriangulo.Checked)
            {
                int b;
                b = int.Parse(txtL.Text);
                lbR.Text = LCFiguras.Triangulo.MostrarPerimetro(b);
            }
            if (rbCuadrado.Checked)
            {
                int b;
                b = int.Parse(txtL.Text);
                lbR.Text = LCFiguras.Cuadrado.MostrarPerimetro(b);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbTriangulo.Checked)
            {
                int b, h;
                b = int.Parse(txtL.Text);
                h = int.Parse(txtH.Text);

                lbR.Text = LCFiguras.Triangulo.MostrarArea(b, h);
            }
            if (rbCuadrado.Checked)
            {
                int b, h;
                b = int.Parse(txtL.Text);
                
                lbR.Text = LCFiguras.Cuadrado.MostrarArea(b);
            }
           
            
        }
    }
}
