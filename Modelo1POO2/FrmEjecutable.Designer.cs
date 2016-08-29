namespace Modelo1POO2
{
    partial class FrmEjecutable
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
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.cboBoletas = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione Boleta";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(164, 39);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(271, 21);
            this.cboClientes.TabIndex = 1;
            this.cboClientes.SelectionChangeCommitted += new System.EventHandler(this.cboClientes_SelectionChangeCommitted);
            // 
            // cboBoletas
            // 
            this.cboBoletas.FormattingEnabled = true;
            this.cboBoletas.Location = new System.Drawing.Point(164, 87);
            this.cboBoletas.Name = "cboBoletas";
            this.cboBoletas.Size = new System.Drawing.Size(121, 21);
            this.cboBoletas.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(340, 90);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgResultados
            // 
            this.dgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultados.Location = new System.Drawing.Point(40, 158);
            this.dgResultados.Name = "dgResultados";
            this.dgResultados.Size = new System.Drawing.Size(514, 179);
            this.dgResultados.TabIndex = 3;
            // 
            // FrmEjecutable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 383);
            this.Controls.Add(this.dgResultados);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cboBoletas);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEjecutable";
            this.Text = "PRIMER SIMULACRO DE POO2";
            this.Load += new System.EventHandler(this.FrmEjecutable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.ComboBox cboBoletas;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgResultados;
    }
}

