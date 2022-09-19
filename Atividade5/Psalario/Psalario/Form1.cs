using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psalario
{
    public partial class Form1 : Form
    {

        double salarioBruto, AliquotaInss, AliquotaIrpf, salarioFamilia, numFilhos, salarioLiquido;
        string sexo, casado, filhos;

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxFilhos.Text = "0";
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void txtNomeFunc_Validated(object sender, EventArgs e)
        {
            if (txtNomeFunc.Text == "")
            {
                MessageBox.Show("Nome é inválido");
                txtNomeFunc.Focus();
            }
            foreach (char c in txtNomeFunc.Text)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Só aceita letras");
                    break;
                }
            }
        }

        private void mskbxSalarioBruto_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxSalarioBruto.Text, out salarioBruto))
            {
                MessageBox.Show("Salário Inválido");
                mskbxSalarioBruto.Focus();
            }
            else
            if (salarioBruto <= 0)
            { 
                MessageBox.Show("Salário Inválido");
                mskbxSalarioBruto.Focus();
            }
    }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double.TryParse(cbxFilhos.Text, out numFilhos);


            if (!double.TryParse(mskbxSalarioBruto.Text, out salarioBruto))
                MessageBox.Show("Salário Inválido");
            else
            if (salarioBruto <= 0)
                MessageBox.Show("Salário Inválido");
            else
                if (salarioBruto <= 800.47)
            {
                AliquotaInss = 0.0765 * salarioBruto;
                txtAliquotaInss.Text = "7,65%";
                txtDescontoInss.Text = AliquotaInss.ToString();
            }
            else
                if (salarioBruto <= 1050)
            {
                AliquotaInss = 0.0865 * salarioBruto;
                txtAliquotaInss.Text = "8,65%";
                txtDescontoInss.Text = AliquotaInss.ToString();
            }
            else
                if (salarioBruto <= 1400.77)
            {
                AliquotaInss = 0.09 * salarioBruto;
                txtAliquotaInss.Text = "9%";
                txtDescontoInss.Text = AliquotaInss.ToString();
            }
            else
                if (salarioBruto <= 2801.56)
            {
                AliquotaInss = 0.11 * salarioBruto;
                txtAliquotaInss.Text = "11%";
                txtDescontoInss.Text = AliquotaInss.ToString();
            }
            else
            if(salarioBruto > 2801.56)
            {
                AliquotaInss = 308.17;
                txtAliquotaInss.Text = "Teto";
                txtDescontoInss.Text = AliquotaInss.ToString();
            }

            if (salarioBruto <= 1257)
            {
                AliquotaIrpf = 0;
                txtDescontoIrpf.Text = AliquotaIrpf.ToString();
                txtAliquotaIrpf.Text = "Isento";
            }
            else
                if (salarioBruto <= 2512.08)
            {
                AliquotaIrpf = salarioBruto * 0.15;
                txtDescontoIrpf.Text = AliquotaIrpf.ToString();
                txtAliquotaIrpf.Text = "15%";
            }
            else
            {
                AliquotaIrpf = salarioBruto * 0.275;
                txtDescontoIrpf.Text = AliquotaIrpf.ToString();
                txtAliquotaIrpf.Text = "27,5%";
            }

            if (salarioBruto <= 435.52)
            {
                salarioFamilia = 22.33 * numFilhos;
                txtSalarioFamilia.Text = salarioFamilia.ToString();
            }

            else
                if (salarioBruto <= 654.61)
            {
                salarioFamilia = 15.74 * numFilhos;
                txtSalarioFamilia.Text = salarioFamilia.ToString();
            }
            else
            {
                salarioFamilia = 0 * numFilhos;
                txtSalarioFamilia.Text = salarioFamilia.ToString();
            }

            salarioLiquido = salarioBruto - AliquotaInss - AliquotaIrpf + salarioFamilia;

            txtSalarioLiquido.Text = salarioLiquido.ToString();

            if (rbtnFeminino.Checked)
                sexo = " da Sra. ";
            else
                sexo = " do Sr. ";

            if (chkbxCasado.Checked && rbtnFeminino.Checked)
            {
                casado = " casada";
            }
            else
                if (!chkbxCasado.Checked && rbtnFeminino.Checked)
                casado = " solteira";
            else 
                if(chkbxCasado.Checked && rbtnMasculino.Checked)
                    casado = " casado";
            else
                casado = " solteiro";
            if (numFilhos == 0 || cbxFilhos.Text == "")
                filhos = " não possui filhos ";
            else
                    if (numFilhos > 1)
                filhos = " possui " + numFilhos + " filhos ";
            else
                filhos = " possui 1 filho "; 


            lblExibe.Text = "Os descontos do salário" + sexo + txtNomeFunc.Text + ", que é" + casado + ", e que" + filhos + "são:";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFunc.Clear();
            txtAliquotaInss.Clear();
            mskbxSalarioBruto.Clear();
            cbxFilhos.Text = "0";
            txtAliquotaInss.Clear();
            txtAliquotaIrpf.Clear();
            txtDescontoInss.Clear();
            txtSalarioFamilia.Clear();
            txtSalarioLiquido.Clear();
            lblExibe.Text = "";
            chkbxCasado.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
