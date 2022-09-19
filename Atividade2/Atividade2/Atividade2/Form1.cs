using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        Double numero1, numero2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDividir_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero2.Text, out numero2) &&
                double.TryParse(txtNumero1.Text, out numero1))
            {
                resultado = numero1 + numero2;
                txtNumero3.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero2.Text, out numero2) &&
                double.TryParse(txtNumero1.Text, out numero1))
            {
                resultado = numero1 - numero2;
                txtNumero3.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero2.Text, out numero2) &&
                double.TryParse(txtNumero1.Text, out numero1))
            {
                resultado = numero1 * numero2;
                txtNumero3.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtNumero3.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero2.Text, out numero2) &&
                double.TryParse(txtNumero1.Text, out numero1))
            {
                if (numero2 == 0)
                    MessageBox.Show("Não pode dividir por zero!");
                else
                {
                    resultado = numero1 / numero2;
                    txtNumero3.Text = resultado.ToString();
                }
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero1.Text, out numero1))
            {
                MessageBox.Show("Número inválido");
            }
        }

        private void txtNumero2_Validated_1(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero2.Text, out numero2))
            {
                MessageBox.Show("Número inválido");
            }
        }

        


    }
}
