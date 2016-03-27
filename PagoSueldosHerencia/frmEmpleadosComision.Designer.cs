namespace PagoSueldosHerencia
{
    partial class frmEmpleadosComision
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtMontoVendido = new System.Windows.Forms.TextBox();
            this.lvR = new System.Windows.Forms.ListView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAGO DE EMPLEDOS POR COMISION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "NOMBRES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "FECHA DE INGRESO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "MONTO VENDIDO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(145, 71);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(145, 102);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(271, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // txtMontoVendido
            // 
            this.txtMontoVendido.Location = new System.Drawing.Point(145, 137);
            this.txtMontoVendido.Name = "txtMontoVendido";
            this.txtMontoVendido.Size = new System.Drawing.Size(100, 20);
            this.txtMontoVendido.TabIndex = 1;
            // 
            // lvR
            // 
            this.lvR.Location = new System.Drawing.Point(33, 179);
            this.lvR.Name = "lvR";
            this.lvR.Size = new System.Drawing.Size(591, 112);
            this.lvR.TabIndex = 3;
            this.lvR.UseCompatibleStateImageBehavior = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(409, 55);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(215, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(529, 102);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistra
            // 
            this.btnRegistra.Location = new System.Drawing.Point(529, 139);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(75, 23);
            this.btnRegistra.TabIndex = 5;
            this.btnRegistra.Text = "REGISTRAR";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(33, 318);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEmpleadosComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 365);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lvR);
            this.Controls.Add(this.txtMontoVendido);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEmpleadosComision";
            this.Text = "Empleados por Comisión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtMontoVendido;
        private System.Windows.Forms.ListView lvR;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.Button btnSalir;
    }
}