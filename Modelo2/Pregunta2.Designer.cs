namespace Modelo2
{
    partial class Pregunta2
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
            this.lblCodigoGenerado = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lvResultados = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPremio = new System.Windows.Forms.Label();
            this.lblCodigoGanador = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SORTEO CON HILOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CODIGO AUTOGENERADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DESCRIPCION DEL PRODUCTO";
            // 
            // lblCodigoGenerado
            // 
            this.lblCodigoGenerado.AutoSize = true;
            this.lblCodigoGenerado.Location = new System.Drawing.Point(220, 67);
            this.lblCodigoGenerado.Name = "lblCodigoGenerado";
            this.lblCodigoGenerado.Size = new System.Drawing.Size(98, 13);
            this.lblCodigoGenerado.TabIndex = 0;
            this.lblCodigoGenerado.Text = "AUTOGENERADO";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(223, 98);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(232, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvResultados
            // 
            this.lvResultados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvResultados.GridLines = true;
            this.lvResultados.Location = new System.Drawing.Point(24, 172);
            this.lvResultados.Name = "lvResultados";
            this.lvResultados.Size = new System.Drawing.Size(431, 175);
            this.lvResultados.TabIndex = 3;
            this.lvResultados.UseCompatibleStateImageBehavior = false;
            this.lvResultados.View = System.Windows.Forms.View.Details;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sortear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ud. se ha ganado una";
            // 
            // lblPremio
            // 
            this.lblPremio.AutoSize = true;
            this.lblPremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremio.Location = new System.Drawing.Point(287, 414);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.Size = new System.Drawing.Size(78, 20);
            this.lblPremio.TabIndex = 0;
            this.lblPremio.Text = "PREMIO";
            // 
            // lblCodigoGanador
            // 
            this.lblCodigoGanador.AutoSize = true;
            this.lblCodigoGanador.Location = new System.Drawing.Point(41, 414);
            this.lblCodigoGanador.Name = "lblCodigoGanador";
            this.lblCodigoGanador.Size = new System.Drawing.Size(84, 13);
            this.lblCodigoGanador.TabIndex = 0;
            this.lblCodigoGanador.Text = "Codigo Ganador";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripcion";
            this.columnHeader2.Width = 307;
            // 
            // Pregunta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lvResultados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblCodigoGanador);
            this.Controls.Add(this.lblPremio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCodigoGenerado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pregunta2";
            this.Text = "Pregunta2";
            this.Load += new System.EventHandler(this.Pregunta2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigoGenerado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvResultados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPremio;
        private System.Windows.Forms.Label lblCodigoGanador;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}