
namespace Rama5_Fichero_de_Productos_e_Inventarios
{
    partial class Form1
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.ldl_buscados_producto = new System.Windows.Forms.Label();
            this.cbx_buscador_productos = new System.Windows.Forms.ComboBox();
            this.lbl_denom_prodcuto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_codigo_producto = new System.Windows.Forms.Label();
            this.tbx_codigo_producto = new System.Windows.Forms.TextBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_stock_minimo = new System.Windows.Forms.Label();
            this.tbx_stock_minimo = new System.Windows.Forms.TextBox();
            this.btn_agregar_stock = new System.Windows.Forms.Button();
            this.lbl_precio_compra = new System.Windows.Forms.Label();
            this.tbx_precio_compra = new System.Windows.Forms.TextBox();
            this.lbl_precio_venta = new System.Windows.Forms.Label();
            this.tbx_precio_vta = new System.Windows.Forms.TextBox();
            this.cbx_Habilita = new System.Windows.Forms.CheckBox();
            this.cbx_desabilitar = new System.Windows.Forms.CheckBox();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(282, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(338, 45);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Fichero de Productos";
            // 
            // ldl_buscados_producto
            // 
            this.ldl_buscados_producto.AutoSize = true;
            this.ldl_buscados_producto.Location = new System.Drawing.Point(28, 91);
            this.ldl_buscados_producto.Name = "ldl_buscados_producto";
            this.ldl_buscados_producto.Size = new System.Drawing.Size(99, 15);
            this.ldl_buscados_producto.TabIndex = 1;
            this.ldl_buscados_producto.Text = "Buscar Productos";
            this.ldl_buscados_producto.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbx_buscador_productos
            // 
            this.cbx_buscador_productos.FormattingEnabled = true;
            this.cbx_buscador_productos.Items.AddRange(new object[] {
            "Leche",
            "Azucar",
            "Yerba Mate",
            "Microonda",
            "Cocina",
            "Heladera",
            "Lavandina",
            "Detergente"});
            this.cbx_buscador_productos.Location = new System.Drawing.Point(133, 83);
            this.cbx_buscador_productos.Name = "cbx_buscador_productos";
            this.cbx_buscador_productos.Size = new System.Drawing.Size(253, 23);
            this.cbx_buscador_productos.TabIndex = 2;
            // 
            // lbl_denom_prodcuto
            // 
            this.lbl_denom_prodcuto.AutoSize = true;
            this.lbl_denom_prodcuto.Location = new System.Drawing.Point(28, 148);
            this.lbl_denom_prodcuto.Name = "lbl_denom_prodcuto";
            this.lbl_denom_prodcuto.Size = new System.Drawing.Size(137, 15);
            this.lbl_denom_prodcuto.TabIndex = 3;
            this.lbl_denom_prodcuto.Text = "Denominación Producto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 23);
            this.textBox1.TabIndex = 4;
            // 
            // lbl_codigo_producto
            // 
            this.lbl_codigo_producto.AutoSize = true;
            this.lbl_codigo_producto.Location = new System.Drawing.Point(407, 148);
            this.lbl_codigo_producto.Name = "lbl_codigo_producto";
            this.lbl_codigo_producto.Size = new System.Drawing.Size(46, 15);
            this.lbl_codigo_producto.TabIndex = 5;
            this.lbl_codigo_producto.Text = "Código";
            // 
            // tbx_codigo_producto
            // 
            this.tbx_codigo_producto.Location = new System.Drawing.Point(459, 145);
            this.tbx_codigo_producto.Name = "tbx_codigo_producto";
            this.tbx_codigo_producto.Size = new System.Drawing.Size(151, 23);
            this.tbx_codigo_producto.TabIndex = 6;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(28, 217);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(58, 15);
            this.lbl_Categoria.TabIndex = 7;
            this.lbl_Categoria.Text = "Categoría";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Limpieza",
            "Alimentos",
            "Electrodomesticos"});
            this.comboBox1.Location = new System.Drawing.Point(114, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_stock_minimo
            // 
            this.lbl_stock_minimo.AutoSize = true;
            this.lbl_stock_minimo.Location = new System.Drawing.Point(407, 217);
            this.lbl_stock_minimo.Name = "lbl_stock_minimo";
            this.lbl_stock_minimo.Size = new System.Drawing.Size(81, 15);
            this.lbl_stock_minimo.TabIndex = 9;
            this.lbl_stock_minimo.Text = "Stock Minimo";
            // 
            // tbx_stock_minimo
            // 
            this.tbx_stock_minimo.Location = new System.Drawing.Point(494, 209);
            this.tbx_stock_minimo.Name = "tbx_stock_minimo";
            this.tbx_stock_minimo.Size = new System.Drawing.Size(116, 23);
            this.tbx_stock_minimo.TabIndex = 11;
            // 
            // btn_agregar_stock
            // 
            this.btn_agregar_stock.Location = new System.Drawing.Point(616, 209);
            this.btn_agregar_stock.Name = "btn_agregar_stock";
            this.btn_agregar_stock.Size = new System.Drawing.Size(101, 23);
            this.btn_agregar_stock.TabIndex = 12;
            this.btn_agregar_stock.Text = "Agregar Stock";
            this.btn_agregar_stock.UseVisualStyleBackColor = true;
            this.btn_agregar_stock.Click += new System.EventHandler(this.btn_agregar_stock_Click);
            // 
            // lbl_precio_compra
            // 
            this.lbl_precio_compra.AutoSize = true;
            this.lbl_precio_compra.Location = new System.Drawing.Point(28, 293);
            this.lbl_precio_compra.Name = "lbl_precio_compra";
            this.lbl_precio_compra.Size = new System.Drawing.Size(124, 15);
            this.lbl_precio_compra.TabIndex = 13;
            this.lbl_precio_compra.Text = "Precio Para la Compra";
            // 
            // tbx_precio_compra
            // 
            this.tbx_precio_compra.Location = new System.Drawing.Point(158, 290);
            this.tbx_precio_compra.Name = "tbx_precio_compra";
            this.tbx_precio_compra.Size = new System.Drawing.Size(139, 23);
            this.tbx_precio_compra.TabIndex = 14;
            // 
            // lbl_precio_venta
            // 
            this.lbl_precio_venta.AutoSize = true;
            this.lbl_precio_venta.Location = new System.Drawing.Point(377, 296);
            this.lbl_precio_venta.Name = "lbl_precio_venta";
            this.lbl_precio_venta.Size = new System.Drawing.Size(111, 15);
            this.lbl_precio_venta.TabIndex = 15;
            this.lbl_precio_venta.Text = "Precio Para la Venta";
            // 
            // tbx_precio_vta
            // 
            this.tbx_precio_vta.Location = new System.Drawing.Point(494, 293);
            this.tbx_precio_vta.Name = "tbx_precio_vta";
            this.tbx_precio_vta.Size = new System.Drawing.Size(151, 23);
            this.tbx_precio_vta.TabIndex = 16;
            this.tbx_precio_vta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cbx_Habilita
            // 
            this.cbx_Habilita.AutoSize = true;
            this.cbx_Habilita.Location = new System.Drawing.Point(36, 368);
            this.cbx_Habilita.Name = "cbx_Habilita";
            this.cbx_Habilita.Size = new System.Drawing.Size(71, 19);
            this.cbx_Habilita.TabIndex = 17;
            this.cbx_Habilita.Text = "Habilitar";
            this.cbx_Habilita.UseVisualStyleBackColor = true;
            // 
            // cbx_desabilitar
            // 
            this.cbx_desabilitar.AutoSize = true;
            this.cbx_desabilitar.Location = new System.Drawing.Point(180, 368);
            this.cbx_desabilitar.Name = "cbx_desabilitar";
            this.cbx_desabilitar.Size = new System.Drawing.Size(88, 19);
            this.cbx_desabilitar.TabIndex = 18;
            this.cbx_desabilitar.Text = "Deshabilitar";
            this.cbx_desabilitar.UseVisualStyleBackColor = true;
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(780, 415);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_grabar.TabIndex = 19;
            this.btn_grabar.Text = "Grabar";
            this.btn_grabar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(687, 415);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 20;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.cbx_desabilitar);
            this.Controls.Add(this.cbx_Habilita);
            this.Controls.Add(this.tbx_precio_vta);
            this.Controls.Add(this.lbl_precio_venta);
            this.Controls.Add(this.tbx_precio_compra);
            this.Controls.Add(this.lbl_precio_compra);
            this.Controls.Add(this.btn_agregar_stock);
            this.Controls.Add(this.tbx_stock_minimo);
            this.Controls.Add(this.lbl_stock_minimo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.tbx_codigo_producto);
            this.Controls.Add(this.lbl_codigo_producto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_denom_prodcuto);
            this.Controls.Add(this.cbx_buscador_productos);
            this.Controls.Add(this.ldl_buscados_producto);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Form1";
            this.Text = "Fichero de Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label ldl_buscados_producto;
        private System.Windows.Forms.ComboBox cbx_buscador_productos;
        private System.Windows.Forms.Label lbl_denom_prodcuto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_codigo_producto;
        private System.Windows.Forms.TextBox tbx_codigo_producto;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_stock_minimo;
        private System.Windows.Forms.TextBox tbx_stock_minimo;
        private System.Windows.Forms.Button btn_agregar_stock;
        private System.Windows.Forms.Label lbl_precio_compra;
        private System.Windows.Forms.TextBox tbx_precio_compra;
        private System.Windows.Forms.Label lbl_precio_venta;
        private System.Windows.Forms.TextBox tbx_precio_vta;
        private System.Windows.Forms.CheckBox cbx_Habilita;
        private System.Windows.Forms.CheckBox cbx_desabilitar;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Button btn_salir;
    }
}

