
namespace Vendedor
{
    partial class frmClientes
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
            this.components = new System.ComponentModel.Container();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txbIngreseDni = new System.Windows.Forms.TextBox();
            this.dtgvClientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.txbProvincia = new System.Windows.Forms.TextBox();
            this.txbLocalidad = new System.Windows.Forms.TextBox();
            this.txbCalle = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.txbCp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenDeVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarCliente.Location = new System.Drawing.Point(161, 13);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(86, 26);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txbIngreseDni
            // 
            this.txbIngreseDni.Location = new System.Drawing.Point(12, 13);
            this.txbIngreseDni.Name = "txbIngreseDni";
            this.txbIngreseDni.Size = new System.Drawing.Size(115, 26);
            this.txbIngreseDni.TabIndex = 1;
            this.txbIngreseDni.Text = "   Ingrese DNI";
            this.txbIngreseDni.Click += new System.EventHandler(this.txbIngreseDni_Click);
            this.txbIngreseDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIngreseDni_KeyPress);
            // 
            // dtgvClientes
            // 
            this.dtgvClientes.AllowUserToAddRows = false;
            this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Provincia,
            this.Localidad,
            this.Editar});
            this.dtgvClientes.Location = new System.Drawing.Point(12, 56);
            this.dtgvClientes.Name = "dtgvClientes";
            this.dtgvClientes.RowHeadersWidth = 47;
            this.dtgvClientes.RowTemplate.Height = 28;
            this.dtgvClientes.Size = new System.Drawing.Size(749, 496);
            this.dtgvClientes.TabIndex = 2;
            this.dtgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvClientes_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 115;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 115;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.Width = 115;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.MinimumWidth = 6;
            this.Provincia.Name = "Provincia";
            this.Provincia.Width = 115;
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "Localidad";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 6;
            this.Localidad.Name = "Localidad";
            this.Localidad.Width = 115;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Text = "Seleccionar";
            this.Editar.ToolTipText = "Seleccionar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 115;
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarCliente.Location = new System.Drawing.Point(300, 271);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(136, 37);
            this.btnGuardarCliente.TabIndex = 4;
            this.btnGuardarCliente.Text = "Editar/Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(16, 55);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(115, 26);
            this.txbNombre.TabIndex = 5;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(168, 55);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(115, 26);
            this.txbApellido.TabIndex = 6;
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(321, 55);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(115, 26);
            this.txbDni.TabIndex = 7;
            this.txbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDni_KeyPress);
            // 
            // txbProvincia
            // 
            this.txbProvincia.Location = new System.Drawing.Point(16, 148);
            this.txbProvincia.Name = "txbProvincia";
            this.txbProvincia.Size = new System.Drawing.Size(115, 26);
            this.txbProvincia.TabIndex = 8;
            // 
            // txbLocalidad
            // 
            this.txbLocalidad.Location = new System.Drawing.Point(168, 148);
            this.txbLocalidad.Name = "txbLocalidad";
            this.txbLocalidad.Size = new System.Drawing.Size(115, 26);
            this.txbLocalidad.TabIndex = 9;
            // 
            // txbCalle
            // 
            this.txbCalle.Location = new System.Drawing.Point(321, 148);
            this.txbCalle.Name = "txbCalle";
            this.txbCalle.Size = new System.Drawing.Size(115, 26);
            this.txbCalle.TabIndex = 10;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(16, 227);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(115, 26);
            this.txbAltura.TabIndex = 11;
            this.txbAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAltura_KeyPress);
            // 
            // txbCp
            // 
            this.txbCp.Location = new System.Drawing.Point(168, 227);
            this.txbCp.Name = "txbCp";
            this.txbCp.Size = new System.Drawing.Size(96, 26);
            this.txbCp.TabIndex = 12;
            this.txbCp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCp_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbCp);
            this.groupBox1.Controls.Add(this.txbAltura);
            this.groupBox1.Controls.Add(this.txbCalle);
            this.groupBox1.Controls.Add(this.txbLocalidad);
            this.groupBox1.Controls.Add(this.txbProvincia);
            this.groupBox1.Controls.Add(this.txbDni);
            this.groupBox1.Controls.Add(this.txbApellido);
            this.groupBox1.Controls.Add(this.txbNombre);
            this.groupBox1.Controls.Add(this.btnGuardarCliente);
            this.groupBox1.Location = new System.Drawing.Point(835, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 325);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(321, 124);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 19);
            this.label.TabIndex = 20;
            this.label.Text = "Calle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "CP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Localidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Provincia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Altura";
            // 
            // btnOrdenDeVenta
            // 
            this.btnOrdenDeVenta.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrdenDeVenta.Location = new System.Drawing.Point(1103, 506);
            this.btnOrdenDeVenta.Name = "btnOrdenDeVenta";
            this.btnOrdenDeVenta.Size = new System.Drawing.Size(191, 51);
            this.btnOrdenDeVenta.TabIndex = 14;
            this.btnOrdenDeVenta.Text = "Orden de venta";
            this.btnOrdenDeVenta.UseVisualStyleBackColor = true;
            this.btnOrdenDeVenta.Click += new System.EventHandler(this.btnOrdenDeVenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(835, 506);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(194, 51);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 602);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOrdenDeVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvClientes);
            this.Controls.Add(this.txbIngreseDni);
            this.Controls.Add(this.btnBuscarCliente);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txbIngreseDni;
        private System.Windows.Forms.DataGridView dtgvClientes;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.TextBox txbProvincia;
        private System.Windows.Forms.TextBox txbLocalidad;
        private System.Windows.Forms.TextBox txbCalle;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.TextBox txbCp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.Button btnOrdenDeVenta;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}