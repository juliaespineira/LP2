namespace PMetodos
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnIserir1 = new System.Windows.Forms.Button();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(41, 20);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            this.lblPalavra1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(121, 17);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 26);
            this.txtPalavra1.TabIndex = 1;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(287, 16);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(203, 35);
            this.btnComparar.TabIndex = 2;
            this.btnComparar.Text = "Comparar Iguais";
            this.btnComparar.UseVisualStyleBackColor = true;
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(41, 91);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra2.TabIndex = 3;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(121, 91);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 26);
            this.txtPalavra2.TabIndex = 4;
            // 
            // btnIserir1
            // 
            this.btnIserir1.Location = new System.Drawing.Point(287, 76);
            this.btnIserir1.Name = "btnIserir1";
            this.btnIserir1.Size = new System.Drawing.Size(203, 35);
            this.btnIserir1.TabIndex = 5;
            this.btnIserir1.Text = "Inserir 1 no meio do 2";
            this.btnIserir1.UseVisualStyleBackColor = true;
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(287, 136);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(203, 35);
            this.btnInserir2.TabIndex = 6;
            this.btnInserir2.Text = "Inserir ** no meio do 1";
            this.btnInserir2.UseVisualStyleBackColor = true;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 605);
            this.Controls.Add(this.btnInserir2);
            this.Controls.Add(this.btnIserir1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnIserir1;
        private System.Windows.Forms.Button btnInserir2;
    }
}