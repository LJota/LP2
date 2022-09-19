namespace PTesteMetodos
{
    partial class frmExercicio4
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
            this.rtbConteudo = new System.Windows.Forms.RichTextBox();
            this.btnNums = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbConteudo
            // 
            this.rtbConteudo.Location = new System.Drawing.Point(151, 14);
            this.rtbConteudo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbConteudo.Name = "rtbConteudo";
            this.rtbConteudo.Size = new System.Drawing.Size(376, 174);
            this.rtbConteudo.TabIndex = 0;
            this.rtbConteudo.Text = "";
            // 
            // btnNums
            // 
            this.btnNums.Location = new System.Drawing.Point(28, 198);
            this.btnNums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNums.Name = "btnNums";
            this.btnNums.Size = new System.Drawing.Size(171, 123);
            this.btnNums.TabIndex = 1;
            this.btnNums.Text = "Quantidade de caracteres númericos";
            this.btnNums.UseVisualStyleBackColor = true;
            this.btnNums.Click += new System.EventHandler(this.btnNums_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(254, 198);
            this.btnBranco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(171, 123);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Posição onde há o primeiro espaço em branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.Location = new System.Drawing.Point(487, 198);
            this.btnLetras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(171, 123);
            this.btnLetras.TabIndex = 3;
            this.btnLetras.Text = "Quantidade de cacteres alfabéticos";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(256, 360);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(169, 26);
            this.txtResultado.TabIndex = 4;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(700, 198);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(171, 123);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNums);
            this.Controls.Add(this.rtbConteudo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConteudo;
        private System.Windows.Forms.Button btnNums;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpar;
    }
}