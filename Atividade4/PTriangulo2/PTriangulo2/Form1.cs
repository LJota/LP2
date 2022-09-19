using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo2
{
    public partial class Form1 : Form
    {
        double A, B, C, Teste;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtLadoA_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLadoA.Text, out A))
                MessageBox.Show("Lado A não é válido");
        }

        private void txtLadoB_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLadoB.Text, out B))
                MessageBox.Show("Lado B não é válido");
        }

        private void txtLadoC_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLadoC.Text, out C))
                MessageBox.Show("Lado C não é válido");
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLadoA.Text, out A))
            {
                MessageBox.Show("Lado A não é válido");
                txtLadoA.Focus();
            }
            else
                if (!double.TryParse(txtLadoB.Text, out B))
                {
                    MessageBox.Show("Lado B não é válido");
                    txtLadoB.Focus();
                }
                else
                    if (!double.TryParse(txtLadoC.Text, out C))
                    {
                        MessageBox.Show("Lado C não é válido");
                        txtLadoC.Focus();
                    }
                    else
                    {
                        if ((A < (B + C)) && (A > Math.Abs(B - C)) &&
                            (B < (A + C)) && (B > Math.Abs(A - C)) &&
                            (C < (A + B)) && (C > Math.Abs(A - B)))
                        {
                            if ((A == B) && (B == C))
                                MessageBox.Show("Triângulo é Equilátero");
                            else
                                if ((A == B) || (A == C))
                                    MessageBox.Show("Triângulo é Isósceles");
                                else
                                    MessageBox.Show("Triângulo é escaleno");
                        }
                        else
                            MessageBox.Show("Triângulo inválido");
                    }

                    }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

