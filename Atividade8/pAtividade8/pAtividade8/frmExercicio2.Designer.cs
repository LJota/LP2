namespace pAtividade8
{
    partial class frmExercicio2
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
            this.btnLetraH = new System.Windows.Forms.Button();
            this.txtLetraN = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLetraH
            // 
            this.btnLetraH.Location = new System.Drawing.Point(317, 215);
            this.btnLetraH.Name = "btnLetraH";
            this.btnLetraH.Size = new System.Drawing.Size(104, 51);
            this.btnLetraH.TabIndex = 0;
            this.btnLetraH.Text = "Descubra H";
            this.btnLetraH.UseVisualStyleBackColor = true;
            this.btnLetraH.Click += new System.EventHandler(this.btnLetraH_Click);
            // 
            // txtLetraN
            // 
            this.txtLetraN.Location = new System.Drawing.Point(321, 152);
            this.txtLetraN.Name = "txtLetraN";
            this.txtLetraN.Size = new System.Drawing.Size(100, 20);
            this.txtLetraN.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(214, 155);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(92, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Digite um número:";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 382);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtLetraN);
            this.Controls.Add(this.btnLetraH);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLetraH;
        private System.Windows.Forms.TextBox txtLetraN;
        private System.Windows.Forms.Label lblNumero;
    }
}