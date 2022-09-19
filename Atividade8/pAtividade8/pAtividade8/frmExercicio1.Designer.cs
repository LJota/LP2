namespace pAtividade8
{
    partial class frmExercício1
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
            this.btnParLetras = new System.Windows.Forms.Button();
            this.btnLetrasR = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbConteudo
            // 
            this.rtbConteudo.Location = new System.Drawing.Point(144, 45);
            this.rtbConteudo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbConteudo.MaxLength = 100;
            this.rtbConteudo.Name = "rtbConteudo";
            this.rtbConteudo.Size = new System.Drawing.Size(565, 269);
            this.rtbConteudo.TabIndex = 0;
            this.rtbConteudo.Text = "";
            // 
            // btnParLetras
            // 
            this.btnParLetras.Location = new System.Drawing.Point(515, 338);
            this.btnParLetras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParLetras.Name = "btnParLetras";
            this.btnParLetras.Size = new System.Drawing.Size(138, 105);
            this.btnParLetras.TabIndex = 1;
            this.btnParLetras.Text = "n° par letras";
            this.btnParLetras.UseVisualStyleBackColor = true;
            this.btnParLetras.Click += new System.EventHandler(this.btnParLetras_Click);
            // 
            // btnLetrasR
            // 
            this.btnLetrasR.Location = new System.Drawing.Point(335, 338);
            this.btnLetrasR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLetrasR.Name = "btnLetrasR";
            this.btnLetrasR.Size = new System.Drawing.Size(135, 105);
            this.btnLetrasR.TabIndex = 2;
            this.btnLetrasR.Text = "n° letras r";
            this.btnLetrasR.UseVisualStyleBackColor = true;
            this.btnLetrasR.Click += new System.EventHandler(this.btnLetrasR_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(165, 338);
            this.btnBranco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(124, 105);
            this.btnBranco.TabIndex = 3;
            this.btnBranco.Text = "Espaços em branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(716, 108);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 76);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercício1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 562);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnLetrasR);
            this.Controls.Add(this.btnParLetras);
            this.Controls.Add(this.rtbConteudo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercício1";
            this.Text = "frmExercício1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConteudo;
        private System.Windows.Forms.Button btnParLetras;
        private System.Windows.Forms.Button btnLetrasR;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnLimpar;
    }
}