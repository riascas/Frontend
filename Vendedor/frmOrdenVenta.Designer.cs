
namespace Vendedor
{
    partial class frmOrdenVenta
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
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.btnProducto = new System.Windows.Forms.Button();
            this.dtgvProductos = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbMetodopago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCvc = new System.Windows.Forms.TextBox();
            this.txbFechaTarjeta = new System.Windows.Forms.TextBox();
            this.txbNombreTarjeta = new System.Windows.Forms.TextBox();
            this.txbNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.btnGuardarOrden = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNroTarjeta = new System.Windows.Forms.Label();
            this.lblFechaTarjeta = new System.Windows.Forms.Label();
            this.lblNombreTarjet = new System.Windows.Forms.Label();
            this.lblCvcTarjeta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txbProducto
            // 
            this.txbProducto.Location = new System.Drawing.Point(33, 46);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.Size = new System.Drawing.Size(143, 26);
            this.txbProducto.TabIndex = 0;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(228, 46);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(127, 26);
            this.txbCantidad.TabIndex = 1;
            // 
            // btnProducto
            // 
            this.btnProducto.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProducto.Location = new System.Drawing.Point(374, 46);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(86, 26);
            this.btnProducto.TabIndex = 2;
            this.btnProducto.Text = "Agregar";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // dtgvProductos
            // 
            this.dtgvProductos.AllowUserToAddRows = false;
            this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.PrecioUnitario,
            this.PrecioTotal,
            this.Eliminar});
            this.dtgvProductos.Location = new System.Drawing.Point(12, 128);
            this.dtgvProductos.Name = "dtgvProductos";
            this.dtgvProductos.RowHeadersWidth = 47;
            this.dtgvProductos.RowTemplate.Height = 28;
            this.dtgvProductos.Size = new System.Drawing.Size(625, 265);
            this.dtgvProductos.TabIndex = 3;
            this.dtgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProductos_CellContentClick);
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
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 115;
            // 
            // cmbMetodopago
            // 
            this.cmbMetodopago.FormattingEnabled = true;
            this.cmbMetodopago.Location = new System.Drawing.Point(816, 115);
            this.cmbMetodopago.Name = "cmbMetodopago";
            this.cmbMetodopago.Size = new System.Drawing.Size(139, 27);
            this.cmbMetodopago.TabIndex = 4;
            this.cmbMetodopago.SelectedIndexChanged += new System.EventHandler(this.cmbMetodopago_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(675, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Metodo de pago:";
            // 
            // txbCvc
            // 
            this.txbCvc.Location = new System.Drawing.Point(831, 273);
            this.txbCvc.Name = "txbCvc";
            this.txbCvc.Size = new System.Drawing.Size(115, 26);
            this.txbCvc.TabIndex = 6;
            // 
            // txbFechaTarjeta
            // 
            this.txbFechaTarjeta.Location = new System.Drawing.Point(831, 185);
            this.txbFechaTarjeta.Name = "txbFechaTarjeta";
            this.txbFechaTarjeta.Size = new System.Drawing.Size(115, 26);
            this.txbFechaTarjeta.TabIndex = 7;
            // 
            // txbNombreTarjeta
            // 
            this.txbNombreTarjeta.Location = new System.Drawing.Point(686, 273);
            this.txbNombreTarjeta.Name = "txbNombreTarjeta";
            this.txbNombreTarjeta.Size = new System.Drawing.Size(115, 26);
            this.txbNombreTarjeta.TabIndex = 8;
            // 
            // txbNumeroTarjeta
            // 
            this.txbNumeroTarjeta.Location = new System.Drawing.Point(686, 185);
            this.txbNumeroTarjeta.Name = "txbNumeroTarjeta";
            this.txbNumeroTarjeta.Size = new System.Drawing.Size(115, 26);
            this.txbNumeroTarjeta.TabIndex = 9;
            // 
            // btnGuardarOrden
            // 
            this.btnGuardarOrden.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarOrden.Location = new System.Drawing.Point(792, 436);
            this.btnGuardarOrden.Name = "btnGuardarOrden";
            this.btnGuardarOrden.Size = new System.Drawing.Size(154, 46);
            this.btnGuardarOrden.TabIndex = 11;
            this.btnGuardarOrden.Text = "Guardar orden";
            this.btnGuardarOrden.UseVisualStyleBackColor = true;
            this.btnGuardarOrden.Click += new System.EventHandler(this.btnGuardarOrden_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(646, 436);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(124, 46);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantidad";
            // 
            // lblNroTarjeta
            // 
            this.lblNroTarjeta.AutoSize = true;
            this.lblNroTarjeta.Location = new System.Drawing.Point(686, 157);
            this.lblNroTarjeta.Name = "lblNroTarjeta";
            this.lblNroTarjeta.Size = new System.Drawing.Size(32, 19);
            this.lblNroTarjeta.TabIndex = 15;
            this.lblNroTarjeta.Text = "Nro";
            // 
            // lblFechaTarjeta
            // 
            this.lblFechaTarjeta.AutoSize = true;
            this.lblFechaTarjeta.Location = new System.Drawing.Point(831, 163);
            this.lblFechaTarjeta.Name = "lblFechaTarjeta";
            this.lblFechaTarjeta.Size = new System.Drawing.Size(74, 19);
            this.lblFechaTarjeta.TabIndex = 16;
            this.lblFechaTarjeta.Text = "Fecha vcto";
            // 
            // lblNombreTarjet
            // 
            this.lblNombreTarjet.AutoSize = true;
            this.lblNombreTarjet.Location = new System.Drawing.Point(686, 245);
            this.lblNombreTarjet.Name = "lblNombreTarjet";
            this.lblNombreTarjet.Size = new System.Drawing.Size(63, 19);
            this.lblNombreTarjet.TabIndex = 17;
            this.lblNombreTarjet.Text = "Nombre ";
            // 
            // lblCvcTarjeta
            // 
            this.lblCvcTarjeta.AutoSize = true;
            this.lblCvcTarjeta.Location = new System.Drawing.Point(831, 251);
            this.lblCvcTarjeta.Name = "lblCvcTarjeta";
            this.lblCvcTarjeta.Size = new System.Drawing.Size(36, 19);
            this.lblCvcTarjeta.TabIndex = 18;
            this.lblCvcTarjeta.Text = "CVC";
            // 
            // frmOrdenVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 509);
            this.Controls.Add(this.lblCvcTarjeta);
            this.Controls.Add(this.lblNombreTarjet);
            this.Controls.Add(this.lblFechaTarjeta);
            this.Controls.Add(this.lblNroTarjeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardarOrden);
            this.Controls.Add(this.txbNumeroTarjeta);
            this.Controls.Add(this.txbNombreTarjeta);
            this.Controls.Add(this.txbFechaTarjeta);
            this.Controls.Add(this.txbCvc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMetodopago);
            this.Controls.Add(this.dtgvProductos);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.txbProducto);
            this.Name = "frmOrdenVenta";
            this.Text = "frmFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.DataGridView dtgvProductos;
        private System.Windows.Forms.ComboBox cmbMetodopago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCvc;
        private System.Windows.Forms.TextBox txbFechaTarjeta;
        private System.Windows.Forms.TextBox txbNombreTarjeta;
        private System.Windows.Forms.TextBox txbNumeroTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button btnGuardarOrden;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNroTarjeta;
        private System.Windows.Forms.Label lblFechaTarjeta;
        private System.Windows.Forms.Label lblNombreTarjet;
        private System.Windows.Forms.Label lblCvcTarjeta;
    }
}