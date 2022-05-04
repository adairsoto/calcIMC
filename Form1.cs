using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class7_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double p = double.Parse(txtPeso.Text);
            double a = double.Parse(txtAltura.Text);

            IMC imc = new IMC();

            imc.Peso = p;
            imc.Altura = a;
           
            lblResultado.Text = $"IMC: {imc.CalcIMC():F2} - {imc.FaixasIMC()}";
        }
    }
}
