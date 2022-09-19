using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pIMC
{
    public partial class Form1 : Form
    {
        double Altura, Peso, IMC;

        private void txtPeso_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPeso.Text, out Peso))
                MessageBox.Show("Peso Inválido");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtIMC.Clear();
            txtCategoria.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAltura.Text, out Altura))
            {
                MessageBox.Show("Altura Inválida");
                txtAltura.Focus();
            }
            else
            if (!double.TryParse(txtPeso.Text, out Peso))
            {
                MessageBox.Show("Peso Inválido");
                txtPeso.Focus();
            }
            else
            {
                IMC = Peso / (Altura * Altura);
                txtIMC.Text = IMC.ToString();
            }
            if (IMC < 18.5)
            {
                txtCategoria.Text = "Abaixo do peso";
            }
            else
                if(IMC < 24.9)
            {
                txtCategoria.Text = "Peso Normal";
            }
            else
                if (IMC < 29.9)
            {
                txtCategoria.Text = "Sobrepeso";
            }
            else
                if (IMC < 34.9)
            {
                txtCategoria.Text = "Obesidade grau I";
            }
            else
                if (IMC < 39.9)
            {
                txtCategoria.Text = "Obesidade grau II";
            }
            else
                txtCategoria.Text = "Obesidade grau III";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            if(!double.TryParse(txtAltura.Text, out Altura))
                MessageBox.Show("Altura Inválida");
        }

    }
}
