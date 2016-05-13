namespace Modelo2
{
    partial class Pregunta1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDescripcionR = new System.Windows.Forms.TextBox();
            this.txtPrecioR = new System.Windows.Forms.TextBox();
            this.cboProveedorR = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lvListadoL = new System.Windows.Forms.ListView();
            this.btnASC = new System.Windows.Forms.Button();
            this.btnDESC = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProveedorC = new System.Windows.Forms.ComboBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvListadoC = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de Productos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(36, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 267);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cboProveedorR);
            this.tabPage1.Controls.Add(this.txtPrecioR);
            this.tabPage1.Controls.Add(this.txtDescripcionR);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblCodigo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "REGISTRO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDESC);
            this.tabPage2.Controls.Add(this.btnASC);
            this.tabPage2.Controls.Add(this.lvListadoL);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LISTADO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvListadoC);
            this.tabPage3.Controls.Add(this.cboProveedorC);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(505, 241);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CONSULTA";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DESCRIPCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "PRECIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "PROVEEDOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CODIGO";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(363, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(17, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "lbl";
            // 
            // txtDescripcionR
            // 
            this.txtDescripcionR.Location = new System.Drawing.Point(140, 65);
            this.txtDescripcionR.Name = "txtDescripcionR";
            this.txtDescripcionR.Size = new System.Drawing.Size(169, 20);
            this.txtDescripcionR.TabIndex = 1;
            // 
            // txtPrecioR
            // 
            this.txtPrecioR.Location = new System.Drawing.Point(140, 103);
            this.txtPrecioR.Name = "txtPrecioR";
            this.txtPrecioR.Size = new System.Drawing.Size(108, 20);
            this.txtPrecioR.TabIndex = 1;
            // 
            // cboProveedorR
            // 
            this.cboProveedorR.FormattingEnabled = true;
            this.cboProveedorR.Location = new System.Drawing.Point(140, 157);
            this.cboProveedorR.Name = "cboProveedorR";
            this.cboProveedorR.Size = new System.Drawing.Size(108, 21);
            this.cboProveedorR.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lvListadoL
            // 
            this.lvListadoL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvListadoL.GridLines = true;
            this.lvListadoL.Location = new System.Drawing.Point(21, 33);
            this.lvListadoL.Name = "lvListadoL";
            this.lvListadoL.Size = new System.Drawing.Size(420, 184);
            this.lvListadoL.TabIndex = 0;
            this.lvListadoL.UseCompatibleStateImageBehavior = false;
            this.lvListadoL.View = System.Windows.Forms.View.Details;
            // 
            // btnASC
            // 
            this.btnASC.Location = new System.Drawing.Point(447, 43);
            this.btnASC.Name = "btnASC";
            this.btnASC.Size = new System.Drawing.Size(52, 23);
            this.btnASC.TabIndex = 1;
            this.btnASC.Text = "ASC";
            this.btnASC.UseVisualStyleBackColor = true;
            this.btnASC.Click += new System.EventHandler(this.btnASC_Click);
            // 
            // btnDESC
            // 
            this.btnDESC.Location = new System.Drawing.Point(447, 72);
            this.btnDESC.Name = "btnDESC";
            this.btnDESC.Size = new System.Drawing.Size(52, 23);
            this.btnDESC.TabIndex = 1;
            this.btnDESC.Text = "DES";
            this.btnDESC.UseVisualStyleBackColor = true;
            this.btnDESC.Click += new System.EventHandler(this.btnDESC_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Proveedor";
            // 
            // cboProveedorC
            // 
            this.cboProveedorC.FormattingEnabled = true;
            this.cboProveedorC.Location = new System.Drawing.Point(157, 11);
            this.cboProveedorC.Name = "cboProveedorC";
            this.cboProveedorC.Size = new System.Drawing.Size(121, 21);
            this.cboProveedorC.TabIndex = 1;
            this.cboProveedorC.SelectedIndexChanged += new System.EventHandler(this.cboProveedorC_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripcion";
            this.columnHeader2.Width = 182;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Proveedor";
            this.columnHeader4.Width = 117;
            // 
            // lvListadoC
            // 
            this.lvListadoC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvListadoC.GridLines = true;
            this.lvListadoC.Location = new System.Drawing.Point(27, 38);
            this.lvListadoC.Name = "lvListadoC";
            this.lvListadoC.Size = new System.Drawing.Size(447, 184);
            this.lvListadoC.TabIndex = 2;
            this.lvListadoC.UseCompatibleStateImageBehavior = false;
            this.lvListadoC.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Codigo";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Descripcion";
            this.columnHeader6.Width = 182;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Precio";
            this.columnHeader7.Width = 71;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Proveedor";
            this.columnHeader8.Width = 117;
            // 
            // Pregunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 387);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Pregunta1";
            this.Text = "Pregunta1";
            this.Load += new System.EventHandler(this.Pregunta1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboProveedorR;
        private System.Windows.Forms.TextBox txtPrecioR;
        private System.Windows.Forms.TextBox txtDescripcionR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDESC;
        private System.Windows.Forms.Button btnASC;
        private System.Windows.Forms.ListView lvListadoL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvListadoC;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cboProveedorC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}