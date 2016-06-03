namespace SeguridadCriptografia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.btnCifrado = new System.Windows.Forms.Button();
            this.btnDescifrado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIFRADO DE INFORMACIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TEXTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CIFRADO";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(30, 88);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(419, 84);
            this.txtTexto.TabIndex = 1;
            // 
            // txtCifrado
            // 
            this.txtCifrado.Location = new System.Drawing.Point(30, 225);
            this.txtCifrado.Multiline = true;
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.Size = new System.Drawing.Size(419, 84);
            this.txtCifrado.TabIndex = 1;
            // 
            // btnCifrado
            // 
            this.btnCifrado.Location = new System.Drawing.Point(30, 343);
            this.btnCifrado.Name = "btnCifrado";
            this.btnCifrado.Size = new System.Drawing.Size(75, 23);
            this.btnCifrado.TabIndex = 2;
            this.btnCifrado.Text = "Cifrado";
            this.btnCifrado.UseVisualStyleBackColor = true;
            this.btnCifrado.Click += new System.EventHandler(this.btnCifrado_Click);
            // 
            // btnDescifrado
            // 
            this.btnDescifrado.Location = new System.Drawing.Point(227, 343);
            this.btnDescifrado.Name = "btnDescifrado";
            this.btnDescifrado.Size = new System.Drawing.Size(75, 23);
            this.btnDescifrado.TabIndex = 2;
            this.btnDescifrado.Text = "Descifrado";
            this.btnDescifrado.UseVisualStyleBackColor = true;
            this.btnDescifrado.Click += new System.EventHandler(this.btnDescifrado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 394);
            this.Controls.Add(this.btnDescifrado);
            this.Controls.Add(this.btnCifrado);
            this.Controls.Add(this.txtCifrado);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtCifrado;
        private System.Windows.Forms.Button btnCifrado;
        private System.Windows.Forms.Button btnDescifrado;
    }
}

