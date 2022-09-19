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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnLetraH_Click(object sender, EventArgs e)
        {
                int letraN;
                double letraH = 0;
                double i = 1;

                if ((int.TryParse(txtLetraN.Text, out letraN)) && letraN > 0)
                {
                    while (i <= letraN)
                    {
                      
                        letraH += Convert.ToDouble (1 / i);

                        i++;

                    }

                    MessageBox.Show("H =" + letraH);
                }
                else
                    MessageBox.Show("Valor Inválido! Corrija.");
            
        }


    }

}

