
namespace Rama5_Fichero_de_Productos_e_Inventarios
{
    partial class Stock_minimo
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
            this.lbl_carga_stock_minimo = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.cbx_busca_producto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Productos = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_BuscaCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_carga_stock_minimo
            // 
            this.lbl_carga_stock_minimo.AutoSize = true;
            this.lbl_carga_stock_minimo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_carga_stock_minimo.Location = new System.Drawing.Point(249, 9);
            this.lbl_carga_stock_minimo.Name = "lbl_carga_stock_minimo";
            this.lbl_carga_stock_minimo.Size = new System.Drawing.Size(277, 37);
            this.lbl_carga_stock_minimo.TabIndex = 0;
            this.lbl_carga_stock_minimo.Text = "Carga Stock Minimo";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(713, 415);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Grabar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(632, 415);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // cbx_busca_producto
            // 
            this.cbx_busca_producto.FormattingEnabled = true;
            this.cbx_busca_producto.Items.AddRange(new object[] {
            "Leche",
            "Yerba",
            "Azucar",
            "Cocina",
            "Heladera"});
            this.cbx_busca_producto.Location = new System.Drawing.Point(193, 371);
            this.cbx_busca_producto.Name = "cbx_busca_producto";
            this.cbx_busca_producto.Size = new System.Drawing.Size(262, 23);
            this.cbx_busca_producto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Productos
            // 
            this.Productos.HeaderText = "Producto";
            this.Productos.Name = "Productos";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Producto";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar por Categoria";
            // 
            // cbx_BuscaCategoria
            // 
            this.cbx_BuscaCategoria.FormattingEnabled = true;
            this.cbx_BuscaCategoria.Items.AddRange(new object[] {
            "Alimentos",
            "Limpieza",
            "Electrodomesticos"});
            this.cbx_BuscaCategoria.Location = new System.Drawing.Point(193, 400);
            this.cbx_BuscaCategoria.Name = "cbx_BuscaCategoria";
            this.cbx_BuscaCategoria.Size = new System.Drawing.Size(262, 23);
            this.cbx_BuscaCategoria.TabIndex = 5;
            // 
            // Stock_minimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_BuscaCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_busca_producto);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_carga_stock_minimo);
            this.Name = "Stock_minimo";
            this.Text = "Stock_minimo";
            this.Load += new System.EventHandler(this.Stock_minimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_carga_stock_minimo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ComboBox cbx_busca_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Productos;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_BuscaCategoria;
    }
}