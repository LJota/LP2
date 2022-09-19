namespace PTriangulo2
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(524, 346);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 47);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(365, 346);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(101, 47);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(252, 104);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(70, 24);
            this.lblLadoA.TabIndex = 2;
            this.lblLadoA.Text = "Lado A";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(252, 171);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(69, 24);
            this.lblLadoB.TabIndex = 3;
            this.lblLadoB.Text = "Lado B";
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(252, 237);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(70, 24);
            this.lblLadoC.TabIndex = 4;
            this.lblLadoC.Text = "Lado C";
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(446, 104);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(100, 29);
            this.txtLadoA.TabIndex = 5;
            this.txtLadoA.Validated += new System.EventHandler(this.txtLadoA_Validated);
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(446, 166);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(100, 29);
            this.txtLadoB.TabIndex = 6;
            this.txtLadoB.Validated += new System.EventHandler(this.txtLadoB_Validated);
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(446, 237);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(100, 29);
            this.txtLadoC.TabIndex = 7;
            this.txtLadoC.Validated += new System.EventHandler(this.txtLadoC_Validated);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(660, 346);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 47);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 529);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnLimpar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.Button btnSair;
    }
}

