
namespace Vendedor
{
    partial class frmVendedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNombreCliente = new System.Windows.Forms.TextBox();
            this.txbApellidoCliente = new System.Windows.Forms.TextBox();
            this.txbDniCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCalleCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbAlturaCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbProvinciaCliente = new System.Windows.Forms.TextBox();
            this.txbLocalidadCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbCpCliente = new System.Windows.Forms.TextBox();
            this.txbIngreseDni = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gpCliente = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNombreProducto = new System.Windows.Forms.TextBox();
            this.dtgvProducto = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txbNroTarjeta = new System.Windows.Forms.TextBox();
            this.txbNombreTarjeta = new System.Windows.Forms.TextBox();
            this.txtFechaTarjeta = new System.Windows.Forms.TextBox();
            this.txbCvcTarjeta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardarOrden = new System.Windows.Forms.Button();
            this.gpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-295, -59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(-259, -106);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(55, 19);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(290, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(508, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "DNI:";
            // 
            // txbNombreCliente
            // 
            this.txbNombreCliente.Location = new System.Drawing.Point(140, 132);
            this.txbNombreCliente.Name = "txbNombreCliente";
            this.txbNombreCliente.Size = new System.Drawing.Size(121, 26);
            this.txbNombreCliente.TabIndex = 8;
            // 
            // txbApellidoCliente
            // 
            this.txbApellidoCliente.Location = new System.Drawing.Point(375, 132);
            this.txbApellidoCliente.Name = "txbApellidoCliente";
            this.txbApellidoCliente.Size = new System.Drawing.Size(115, 26);
            this.txbApellidoCliente.TabIndex = 15;
            // 
            // txbDniCliente
            // 
            this.txbDniCliente.Location = new System.Drawing.Point(552, 132);
            this.txbDniCliente.Name = "txbDniCliente";
            this.txbDniCliente.Size = new System.Drawing.Size(98, 26);
            this.txbDniCliente.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(452, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 30);
            this.label9.TabIndex = 19;
            this.label9.Text = "Orden de venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(48, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Calle:";
            // 
            // txtCalleCliente
            // 
            this.txtCalleCliente.Location = new System.Drawing.Point(140, 239);
            this.txtCalleCliente.Name = "txtCalleCliente";
            this.txtCalleCliente.Size = new System.Drawing.Size(115, 26);
            this.txtCalleCliente.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(290, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Altura:";
            // 
            // txbAlturaCliente
            // 
            this.txbAlturaCliente.Location = new System.Drawing.Point(375, 239);
            this.txbAlturaCliente.Name = "txbAlturaCliente";
            this.txbAlturaCliente.Size = new System.Drawing.Size(94, 26);
            this.txbAlturaCliente.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(48, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Provincia:";
            // 
            // txbProvinciaCliente
            // 
            this.txbProvinciaCliente.Location = new System.Drawing.Point(140, 187);
            this.txbProvinciaCliente.Name = "txbProvinciaCliente";
            this.txbProvinciaCliente.Size = new System.Drawing.Size(121, 26);
            this.txbProvinciaCliente.TabIndex = 26;
            // 
            // txbLocalidadCliente
            // 
            this.txbLocalidadCliente.Location = new System.Drawing.Point(375, 185);
            this.txbLocalidadCliente.Name = "txbLocalidadCliente";
            this.txbLocalidadCliente.Size = new System.Drawing.Size(115, 26);
            this.txbLocalidadCliente.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(281, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Localidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(508, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "CP:";
            // 
            // txbCpCliente
            // 
            this.txbCpCliente.Location = new System.Drawing.Point(552, 185);
            this.txbCpCliente.Name = "txbCpCliente";
            this.txbCpCliente.Size = new System.Drawing.Size(81, 26);
            this.txbCpCliente.TabIndex = 30;
            // 
            // txbIngreseDni
            // 
            this.txbIngreseDni.Location = new System.Drawing.Point(26, 40);
            this.txbIngreseDni.Name = "txbIngreseDni";
            this.txbIngreseDni.Size = new System.Drawing.Size(148, 26);
            this.txbIngreseDni.TabIndex = 34;
            this.txbIngreseDni.Text = "    Ingrese dni";
            this.txbIngreseDni.Click += new System.EventHandler(this.txbIngreseDni_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(223, 40);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(86, 26);
            this.btnBuscarCliente.TabIndex = 35;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(531, 244);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(86, 26);
            this.btnGuardarCliente.TabIndex = 37;
            this.btnGuardarCliente.Text = "Guardar cliente";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(707, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 26);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // gpCliente
            // 
            this.gpCliente.Controls.Add(this.btnGuardarCliente);
            this.gpCliente.Controls.Add(this.btnBuscarCliente);
            this.gpCliente.Controls.Add(this.txbIngreseDni);
            this.gpCliente.Controls.Add(this.txbCpCliente);
            this.gpCliente.Controls.Add(this.label13);
            this.gpCliente.Controls.Add(this.label12);
            this.gpCliente.Controls.Add(this.txbLocalidadCliente);
            this.gpCliente.Controls.Add(this.txbProvinciaCliente);
            this.gpCliente.Controls.Add(this.label11);
            this.gpCliente.Controls.Add(this.txbAlturaCliente);
            this.gpCliente.Controls.Add(this.label10);
            this.gpCliente.Controls.Add(this.txtCalleCliente);
            this.gpCliente.Controls.Add(this.label8);
            this.gpCliente.Controls.Add(this.txbDniCliente);
            this.gpCliente.Controls.Add(this.txbApellidoCliente);
            this.gpCliente.Controls.Add(this.txbNombreCliente);
            this.gpCliente.Controls.Add(this.label5);
            this.gpCliente.Controls.Add(this.label4);
            this.gpCliente.Controls.Add(this.label3);
            this.gpCliente.Location = new System.Drawing.Point(12, 46);
            this.gpCliente.Name = "gpCliente";
            this.gpCliente.Size = new System.Drawing.Size(673, 299);
            this.gpCliente.TabIndex = 39;
            this.gpCliente.TabStop = false;
            this.gpCliente.Text = "CLIENTE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(330, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cantidad:";
            // 
            // txbNombreProducto
            // 
            this.txbNombreProducto.Location = new System.Drawing.Point(26, 28);
            this.txbNombreProducto.Name = "txbNombreProducto";
            this.txbNombreProducto.Size = new System.Drawing.Size(287, 26);
            this.txbNombreProducto.TabIndex = 9;
            this.txbNombreProducto.Text = "  Ingrese Nombre";
            this.txbNombreProducto.Click += new System.EventHandler(this.txbNombreProducto_Click);
            // 
            // dtgvProducto
            // 
            this.dtgvProducto.AllowUserToAddRows = false;
            this.dtgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.PrecioUnitario,
            this.PrecioTotal,
            this.Check});
            this.dtgvProducto.Location = new System.Drawing.Point(9, 103);
            this.dtgvProducto.Name = "dtgvProducto";
            this.dtgvProducto.RowHeadersWidth = 47;
            this.dtgvProducto.RowTemplate.Height = 28;
            this.dtgvProducto.Size = new System.Drawing.Size(624, 186);
            this.dtgvProducto.TabIndex = 14;
            this.dtgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProducto_CellContentClick);
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Nombre";
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 115;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 115;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "PrecioVenta";
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 115;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.DataPropertyName = "PrecioTotal";
            this.PrecioTotal.HeaderText = "Precio Total";
            this.PrecioTotal.MinimumWidth = 6;
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.Width = 115;
            // 
            // Check
            // 
            this.Check.HeaderText = "Eliminar";
            this.Check.MinimumWidth = 6;
            this.Check.Name = "Check";
            this.Check.Width = 115;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(419, 29);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(115, 26);
            this.txbCantidad.TabIndex = 17;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(550, 30);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(86, 26);
            this.btnAgregarProducto.TabIndex = 32;
            this.btnAgregarProducto.Text = "Agregar ";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregarProducto);
            this.groupBox1.Controls.Add(this.txbCantidad);
            this.groupBox1.Controls.Add(this.dtgvProducto);
            this.groupBox1.Controls.Add(this.txbNombreProducto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 335);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(547, 303);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 26);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txbNroTarjeta
            // 
            this.txbNroTarjeta.Location = new System.Drawing.Point(15, 53);
            this.txbNroTarjeta.Name = "txbNroTarjeta";
            this.txbNroTarjeta.Size = new System.Drawing.Size(186, 26);
            this.txbNroTarjeta.TabIndex = 42;
            this.txbNroTarjeta.Text = "   Nro Tarjeta";
            this.txbNroTarjeta.Click += new System.EventHandler(this.txbNroTarjeta_Click);
            // 
            // txbNombreTarjeta
            // 
            this.txbNombreTarjeta.Location = new System.Drawing.Point(15, 126);
            this.txbNombreTarjeta.Name = "txbNombreTarjeta";
            this.txbNombreTarjeta.Size = new System.Drawing.Size(115, 26);
            this.txbNombreTarjeta.TabIndex = 43;
            this.txbNombreTarjeta.Text = "   Nombre";
            this.txbNombreTarjeta.Click += new System.EventHandler(this.txbNombreTarjeta_Click);
            // 
            // txtFechaTarjeta
            // 
            this.txtFechaTarjeta.Location = new System.Drawing.Point(221, 53);
            this.txtFechaTarjeta.Name = "txtFechaTarjeta";
            this.txtFechaTarjeta.Size = new System.Drawing.Size(106, 26);
            this.txtFechaTarjeta.TabIndex = 44;
            this.txtFechaTarjeta.Text = "   Fecha vcto";
            this.txtFechaTarjeta.Click += new System.EventHandler(this.txtFechaTarjeta_Click);
            // 
            // txbCvcTarjeta
            // 
            this.txbCvcTarjeta.Location = new System.Drawing.Point(211, 126);
            this.txbCvcTarjeta.Name = "txbCvcTarjeta";
            this.txbCvcTarjeta.Size = new System.Drawing.Size(84, 26);
            this.txbCvcTarjeta.TabIndex = 45;
            this.txbCvcTarjeta.Text = "  CVC";
            this.txbCvcTarjeta.Click += new System.EventHandler(this.txbCvcTarjeta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbCvcTarjeta);
            this.groupBox2.Controls.Add(this.txtFechaTarjeta);
            this.groupBox2.Controls.Add(this.txbNombreTarjeta);
            this.groupBox2.Controls.Add(this.txbNroTarjeta);
            this.groupBox2.Location = new System.Drawing.Point(681, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 235);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tarjeta";
            // 
            // btnGuardarOrden
            // 
            this.btnGuardarOrden.Location = new System.Drawing.Point(762, 747);
            this.btnGuardarOrden.Name = "btnGuardarOrden";
            this.btnGuardarOrden.Size = new System.Drawing.Size(182, 45);
            this.btnGuardarOrden.TabIndex = 46;
            this.btnGuardarOrden.Text = "Guardar Orden";
            this.btnGuardarOrden.UseVisualStyleBackColor = true;
            this.btnGuardarOrden.Click += new System.EventHandler(this.btnGuardarOrden_Click);
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 804);
            this.Controls.Add(this.btnGuardarOrden);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpCliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmVendedor";
            this.Text = "Guardar";
            this.gpCliente.ResumeLayout(false);
            this.gpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNombreCliente;
        private System.Windows.Forms.TextBox txbApellidoCliente;
        private System.Windows.Forms.TextBox txbDniCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCalleCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbAlturaCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbProvinciaCliente;
        private System.Windows.Forms.TextBox txbLocalidadCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbCpCliente;
        private System.Windows.Forms.TextBox txbIngreseDni;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gpCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbNombreProducto;
        private System.Windows.Forms.DataGridView dtgvProducto;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txbNroTarjeta;
        private System.Windows.Forms.TextBox txbNombreTarjeta;
        private System.Windows.Forms.TextBox txtFechaTarjeta;
        private System.Windows.Forms.TextBox txbCvcTarjeta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardarOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
    }
}

