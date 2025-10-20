namespace PMetodos
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
            this.btnContanum = new System.Windows.Forms.Button();
            this.btnCaracterBranco = new System.Windows.Forms.Button();
            this.btnContaLetra = new System.Windows.Forms.Button();
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnContanum
            // 
            this.btnContanum.Location = new System.Drawing.Point(258, 351);
            this.btnContanum.Name = "btnContanum";
            this.btnContanum.Size = new System.Drawing.Size(144, 86);
            this.btnContanum.TabIndex = 0;
            this.btnContanum.Text = "Conta numeros";
            this.btnContanum.UseVisualStyleBackColor = true;
            this.btnContanum.Click += new System.EventHandler(this.btnContanum_Click);
            // 
            // btnCaracterBranco
            // 
            this.btnCaracterBranco.Location = new System.Drawing.Point(408, 351);
            this.btnCaracterBranco.Name = "btnCaracterBranco";
            this.btnCaracterBranco.Size = new System.Drawing.Size(144, 86);
            this.btnCaracterBranco.TabIndex = 1;
            this.btnCaracterBranco.Text = "Posição 1 caracter em branco";
            this.btnCaracterBranco.UseVisualStyleBackColor = true;
            this.btnCaracterBranco.Click += new System.EventHandler(this.btnCaracterBranco_Click);
            // 
            // btnContaLetra
            // 
            this.btnContaLetra.Location = new System.Drawing.Point(558, 351);
            this.btnContaLetra.Name = "btnContaLetra";
            this.btnContaLetra.Size = new System.Drawing.Size(144, 86);
            this.btnContaLetra.TabIndex = 2;
            this.btnContaLetra.Text = "Conta letras";
            this.btnContaLetra.UseVisualStyleBackColor = true;
            this.btnContaLetra.Click += new System.EventHandler(this.btnContaLetra_Click);
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(91, 12);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(774, 308);
            this.rchtxtFrase.TabIndex = 3;
            this.rchtxtFrase.Text = "";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 440);
            this.Controls.Add(this.rchtxtFrase);
            this.Controls.Add(this.btnContaLetra);
            this.Controls.Add(this.btnCaracterBranco);
            this.Controls.Add(this.btnContanum);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContanum;
        private System.Windows.Forms.Button btnCaracterBranco;
        private System.Windows.Forms.Button btnContaLetra;
        private System.Windows.Forms.RichTextBox rchtxtFrase;
    }
}