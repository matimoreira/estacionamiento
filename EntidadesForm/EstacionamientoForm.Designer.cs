namespace EntidadesForm
{
    partial class EstacionamientoForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrecioHora = new System.Windows.Forms.Label();
            this.lblTotalEspacios = new System.Windows.Forms.Label();
            this.lblEspaciosDisponibles = new System.Windows.Forms.Label();
            this.lblEspaciosOcupados = new System.Windows.Forms.Label();
            this.lblTotalFacturado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txbPatente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LvwReservas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPatente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEgresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrecioHora);
            this.groupBox1.Controls.Add(this.lblTotalEspacios);
            this.groupBox1.Controls.Add(this.lblEspaciosDisponibles);
            this.groupBox1.Controls.Add(this.lblEspaciosOcupados);
            this.groupBox1.Controls.Add(this.lblTotalFacturado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturacion";
            // 
            // lblPrecioHora
            // 
            this.lblPrecioHora.AutoSize = true;
            this.lblPrecioHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPrecioHora.Location = new System.Drawing.Point(305, 128);
            this.lblPrecioHora.Name = "lblPrecioHora";
            this.lblPrecioHora.Size = new System.Drawing.Size(20, 24);
            this.lblPrecioHora.TabIndex = 10;
            this.lblPrecioHora.Text = "0";
            // 
            // lblTotalEspacios
            // 
            this.lblTotalEspacios.AutoSize = true;
            this.lblTotalEspacios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTotalEspacios.Location = new System.Drawing.Point(25, 128);
            this.lblTotalEspacios.Name = "lblTotalEspacios";
            this.lblTotalEspacios.Size = new System.Drawing.Size(20, 24);
            this.lblTotalEspacios.TabIndex = 9;
            this.lblTotalEspacios.Text = "0";
            // 
            // lblEspaciosDisponibles
            // 
            this.lblEspaciosDisponibles.AutoSize = true;
            this.lblEspaciosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEspaciosDisponibles.Location = new System.Drawing.Point(530, 47);
            this.lblEspaciosDisponibles.Name = "lblEspaciosDisponibles";
            this.lblEspaciosDisponibles.Size = new System.Drawing.Size(20, 24);
            this.lblEspaciosDisponibles.TabIndex = 8;
            this.lblEspaciosDisponibles.Text = "0";
            // 
            // lblEspaciosOcupados
            // 
            this.lblEspaciosOcupados.AutoSize = true;
            this.lblEspaciosOcupados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEspaciosOcupados.Location = new System.Drawing.Point(305, 47);
            this.lblEspaciosOcupados.Name = "lblEspaciosOcupados";
            this.lblEspaciosOcupados.Size = new System.Drawing.Size(20, 24);
            this.lblEspaciosOcupados.TabIndex = 7;
            this.lblEspaciosOcupados.Text = "0";
            // 
            // lblTotalFacturado
            // 
            this.lblTotalFacturado.AutoSize = true;
            this.lblTotalFacturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTotalFacturado.Location = new System.Drawing.Point(25, 47);
            this.lblTotalFacturado.Name = "lblTotalFacturado";
            this.lblTotalFacturado.Size = new System.Drawing.Size(20, 24);
            this.lblTotalFacturado.TabIndex = 6;
            this.lblTotalFacturado.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total de Espacios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Espacios Disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espacios Ocupados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Facturado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEgresar);
            this.groupBox2.Controls.Add(this.LvwReservas);
            this.groupBox2.Location = new System.Drawing.Point(411, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehiculos Estacionados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIngresar);
            this.groupBox3.Controls.Add(this.txbPatente);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(26, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso de Vehiculos";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnIngresar.Location = new System.Drawing.Point(218, 95);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(112, 39);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txbPatente
            // 
            this.txbPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txbPatente.Location = new System.Drawing.Point(29, 49);
            this.txbPatente.Name = "txbPatente";
            this.txbPatente.Size = new System.Drawing.Size(301, 29);
            this.txbPatente.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Patente";
            // 
            // LvwReservas
            // 
            this.LvwReservas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnPatente,
            this.columnFecha});
            this.LvwReservas.Cursor = System.Windows.Forms.Cursors.Default;
            this.LvwReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvwReservas.FullRowSelect = true;
            this.LvwReservas.GridLines = true;
            this.LvwReservas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LvwReservas.HideSelection = false;
            this.LvwReservas.Location = new System.Drawing.Point(19, 33);
            this.LvwReservas.Name = "LvwReservas";
            this.LvwReservas.Size = new System.Drawing.Size(324, 218);
            this.LvwReservas.TabIndex = 22;
            this.LvwReservas.UseCompatibleStateImageBehavior = false;
            this.LvwReservas.View = System.Windows.Forms.View.Details;            
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // columnPatente
            // 
            this.columnPatente.Text = "Patente";
            this.columnPatente.Width = 172;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha";
            this.columnFecha.Width = 172;
            // 
            // btnEgresar
            // 
            this.btnEgresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEgresar.Location = new System.Drawing.Point(231, 269);
            this.btnEgresar.Name = "btnEgresar";
            this.btnEgresar.Size = new System.Drawing.Size(112, 39);
            this.btnEgresar.TabIndex = 23;
            this.btnEgresar.Text = "Egresar";
            this.btnEgresar.UseVisualStyleBackColor = true;
            this.btnEgresar.Click += new System.EventHandler(this.btnEgresar_Click);
            // 
            // EstacionamientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EstacionamientoForm";
            this.Text = "Estacionamiento";
            this.Load += new System.EventHandler(this.Estacionamiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrecioHora;
        private System.Windows.Forms.Label lblTotalEspacios;
        private System.Windows.Forms.Label lblEspaciosDisponibles;
        private System.Windows.Forms.Label lblEspaciosOcupados;
        private System.Windows.Forms.Label lblTotalFacturado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txbPatente;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ListView LvwReservas;
        private System.Windows.Forms.Button btnEgresar;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnPatente;
        public System.Windows.Forms.ColumnHeader columnFecha;
    }
}

