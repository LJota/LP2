using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PVenda
{        //Prova feita por Matheus Gonsalves Favara e Lucas José Marcondes Rossi
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] matrizVendas = new double[3, 4];
            double totalVendasSem = 0;
            double totalVendasMes = 0;
            double totalVendasGeral = 0;
            string dados;

            int j;
            int i;

            for (i = 0; i < 3; i ++)
            {
                    for (j = 0; j < 4; j++)
                {
                    dados = Interaction.InputBox("Favor, digitar as vendas do mês " + (i + 1).ToString() + " da " + (j + 1).ToString() + "º semana: ", "Entrada de Dados");

                    if (dados == "")
                    {
                        MessageBox.Show("Valor Incorreto!");
                        j--;
                    }
                        else if (!(double.TryParse(dados, out matrizVendas[i, j])))
                        {
                             MessageBox.Show("Valor Incorreto!");
                               j--;
                        }
                            else if (matrizVendas[i, j] < 0)
                            {
                                 MessageBox.Show("Valor Incorreto!");
                                 j--;
                            }
                                else
                                    {
                                        lstbxPlanilha.Items.Add("Total do mês: " + (i + 1).ToString() + " Semana: " + (j + 1).ToString() + " " + matrizVendas[i, j].ToString("C2"));
                                        totalVendasMes += matrizVendas[i, j];
                                    }
                    
                }

                    lstbxPlanilha.Items.Add(">> Total do mês: " + totalVendasMes.ToString("C2"));
                    lstbxPlanilha.Items.Add("----------------------------------------------");
                    totalVendasGeral += totalVendasMes;
                    totalVendasMes = 0;
            }

            lstbxPlanilha.Items.Add(">> Total Geral: " + totalVendasGeral.ToString("C2"));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
