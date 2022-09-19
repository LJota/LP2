using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pAtividade8
{
    public partial class frmExercício1 : Form
    {
        public frmExercício1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;
            int quantidade = 0;

            while(x < rtbConteudo.Text.Length)
            {
                if (rtbConteudo.Text[x] == ' ')
                  quantidade += 1;
              
                x ++;
            }

            MessageBox.Show(quantidade.ToString());

        }

        private void btnLetrasR_Click(object sender, EventArgs e)
        {
            int x = 0;
            int quantidadeR = 0;
            

            while (x < rtbConteudo.Text.Length)
            {
                if (rtbConteudo.Text[x] == 'r')
                    quantidadeR += 1;

                    x += 1;
                               
            }

            MessageBox.Show(quantidadeR.ToString());
        }

        private void btnParLetras_Click(object sender, EventArgs e)
        {
            int x = 1;
            int quantidadeR = 0;


            while (x < rtbConteudo.Text.Length)
            {
                if (rtbConteudo.Text[x] == rtbConteudo.Text[x - 1])
                    quantidadeR += 1;

                x += 1;

            }

            MessageBox.Show(quantidadeR.ToString());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtbConteudo.Clear();
        }
    }
}
