namespace Psalario
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.txtAliquotaInss = new System.Windows.Forms.TextBox();
            this.txtAliquotaIrpf = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtDescontoInss = new System.Windows.Forms.TextBox();
            this.txtDescontoIrpf = new System.Windows.Forms.TextBox();
            this.lblFunc = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblInss = new System.Windows.Forms.Label();
            this.lblIrpf = new System.Windows.Forms.Label();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDescontoInss = new System.Windows.Forms.Label();
            this.lblDescontoIrpf = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkbxCasado = new System.Windows.Forms.CheckBox();
            this.cbxFilhos = new System.Windows.Forms.ComboBox();
            this.lblExibe = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(299, 27);
            this.txtNomeFunc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(132, 22);
            this.txtNomeFunc.TabIndex = 0;
            this.txtNomeFunc.Validated += new System.EventHandler(this.txtNomeFunc_Validated);
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(299, 117);
            this.mskbxSalarioBruto.Margin = new System.Windows.Forms.Padding(4);
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(132, 22);
            this.mskbxSalarioBruto.TabIndex = 1;
            this.mskbxSalarioBruto.Validated += new System.EventHandler(this.mskbxSalarioBruto_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMasculino);
            this.groupBox1.Controls.Add(this.rbtnFeminino);
            this.groupBox1.Location = new System.Drawing.Point(702, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(60, 60);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(37, 20);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.Text = "M";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Checked = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(60, 25);
            this.rbtnFeminino.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(34, 20);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "F";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // txtAliquotaInss
            // 
            this.txtAliquotaInss.Enabled = false;
            this.txtAliquotaInss.Location = new System.Drawing.Point(301, 446);
            this.txtAliquotaInss.Margin = new System.Windows.Forms.Padding(4);
            this.txtAliquotaInss.Name = "txtAliquotaInss";
            this.txtAliquotaInss.Size = new System.Drawing.Size(132, 22);
            this.txtAliquotaInss.TabIndex = 3;
            // 
            // txtAliquotaIrpf
            // 
            this.txtAliquotaIrpf.Enabled = false;
            this.txtAliquotaIrpf.Location = new System.Drawing.Point(301, 527);
            this.txtAliquotaIrpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtAliquotaIrpf.Name = "txtAliquotaIrpf";
            this.txtAliquotaIrpf.Size = new System.Drawing.Size(132, 22);
            this.txtAliquotaIrpf.TabIndex = 4;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(301, 594);
            this.txtSalarioFamilia.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(132, 22);
            this.txtSalarioFamilia.TabIndex = 5;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(301, 651);
            this.txtSalarioLiquido.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(132, 22);
            this.txtSalarioLiquido.TabIndex = 6;
            // 
            // txtDescontoInss
            // 
            this.txtDescontoInss.Enabled = false;
            this.txtDescontoInss.Location = new System.Drawing.Point(837, 446);
            this.txtDescontoInss.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescontoInss.Name = "txtDescontoInss";
            this.txtDescontoInss.Size = new System.Drawing.Size(132, 22);
            this.txtDescontoInss.TabIndex = 7;
            // 
            // txtDescontoIrpf
            // 
            this.txtDescontoIrpf.Enabled = false;
            this.txtDescontoIrpf.Location = new System.Drawing.Point(837, 527);
            this.txtDescontoIrpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescontoIrpf.Name = "txtDescontoIrpf";
            this.txtDescontoIrpf.Size = new System.Drawing.Size(132, 22);
            this.txtDescontoIrpf.TabIndex = 8;
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Location = new System.Drawing.Point(142, 27);
            this.lblFunc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(118, 16);
            this.lblFunc.TabIndex = 9;
            this.lblFunc.Text = "Nome Funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(146, 117);
            this.lblSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(85, 16);
            this.lblSalarioBruto.TabIndex = 10;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // lblInss
            // 
            this.lblInss.AutoSize = true;
            this.lblInss.Location = new System.Drawing.Point(148, 454);
            this.lblInss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInss.Name = "lblInss";
            this.lblInss.Size = new System.Drawing.Size(91, 16);
            this.lblInss.TabIndex = 11;
            this.lblInss.Text = "Aliquota INSS";
            // 
            // lblIrpf
            // 
            this.lblIrpf.AutoSize = true;
            this.lblIrpf.Location = new System.Drawing.Point(148, 536);
            this.lblIrpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIrpf.Name = "lblIrpf";
            this.lblIrpf.Size = new System.Drawing.Size(90, 16);
            this.lblIrpf.TabIndex = 12;
            this.lblIrpf.Text = "Aliquota IRPF";
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(148, 594);
            this.lblFamilia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(98, 16);
            this.lblFamilia.TabIndex = 13;
            this.lblFamilia.Text = "Salário Família";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(148, 660);
            this.lblSalarioLiquido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(98, 16);
            this.lblSalarioLiquido.TabIndex = 14;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // lblDescontoInss
            // 
            this.lblDescontoInss.AutoSize = true;
            this.lblDescontoInss.Location = new System.Drawing.Point(722, 454);
            this.lblDescontoInss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescontoInss.Name = "lblDescontoInss";
            this.lblDescontoInss.Size = new System.Drawing.Size(100, 16);
            this.lblDescontoInss.TabIndex = 15;
            this.lblDescontoInss.Text = "Desconto INSS";
            // 
            // lblDescontoIrpf
            // 
            this.lblDescontoIrpf.AutoSize = true;
            this.lblDescontoIrpf.Location = new System.Drawing.Point(722, 536);
            this.lblDescontoIrpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescontoIrpf.Name = "lblDescontoIrpf";
            this.lblDescontoIrpf.Size = new System.Drawing.Size(99, 16);
            this.lblDescontoIrpf.TabIndex = 16;
            this.lblDescontoIrpf.Text = "Desconto IRPF";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(146, 205);
            this.lblFilhos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(114, 16);
            this.lblFilhos.TabIndex = 18;
            this.lblFilhos.Text = "Número de Filhos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkbxCasado);
            this.panel1.Location = new System.Drawing.Point(702, 194);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 123);
            this.panel1.TabIndex = 19;
            // 
            // chkbxCasado
            // 
            this.chkbxCasado.AutoSize = true;
            this.chkbxCasado.Location = new System.Drawing.Point(48, 34);
            this.chkbxCasado.Margin = new System.Windows.Forms.Padding(4);
            this.chkbxCasado.Name = "chkbxCasado";
            this.chkbxCasado.Size = new System.Drawing.Size(75, 20);
            this.chkbxCasado.TabIndex = 0;
            this.chkbxCasado.Text = "Casado";
            this.chkbxCasado.UseVisualStyleBackColor = true;
            // 
            // cbxFilhos
            // 
            this.cbxFilhos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilhos.FormattingEnabled = true;
            this.cbxFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbxFilhos.Location = new System.Drawing.Point(299, 205);
            this.cbxFilhos.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFilhos.Name = "cbxFilhos";
            this.cbxFilhos.Size = new System.Drawing.Size(160, 24);
            this.cbxFilhos.TabIndex = 20;
            // 
            // lblExibe
            // 
            this.lblExibe.AutoSize = true;
            this.lblExibe.Location = new System.Drawing.Point(148, 377);
            this.lblExibe.Name = "lblExibe";
            this.lblExibe.Size = new System.Drawing.Size(65, 16);
            this.lblExibe.TabIndex = 21;
            this.lblExibe.Text = "O salário ";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(301, 267);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(195, 50);
            this.btnVerificar.TabIndex = 22;
            this.btnVerificar.Text = "Verificar Desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(593, 615);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(155, 61);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(814, 615);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(155, 61);
            this.btnSair.TabIndex = 24;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1105, 756);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblExibe);
            this.Controls.Add(this.cbxFilhos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblDescontoIrpf);
            this.Controls.Add(this.lblDescontoInss);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.lblIrpf);
            this.Controls.Add(this.lblInss);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.txtDescontoIrpf);
            this.Controls.Add(this.txtDescontoInss);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtAliquotaIrpf);
            this.Controls.Add(this.txtAliquotaInss);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.txtNomeFunc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAliquotaInss;
        private System.Windows.Forms.TextBox txtAliquotaIrpf;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtDescontoInss;
        private System.Windows.Forms.TextBox txtDescontoIrpf;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblInss;
        private System.Windows.Forms.Label lblIrpf;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDescontoInss;
        private System.Windows.Forms.Label lblDescontoIrpf;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkbxCasado;
        private System.Windows.Forms.ComboBox cbxFilhos;
        private System.Windows.Forms.Label lblExibe;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

