
namespace Rama2_Gerente
{
    partial class FormProductos
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
            this.lblProductos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProvedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColmAlerta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGenerarAlerta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txbNombreProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(323, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductos.Location = new System.Drawing.Point(137, 142);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(59, 15);
            this.lblProductos.TabIndex = 3;
            this.lblProductos.Text = "Producto:";
            this.lblProductos.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumCategoria,
            this.ColumnProvedor,
            this.ColumOrden,
            this.ColumnProducto,
            this.ColumStock,
            this.ColmAlerta});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(69, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(643, 147);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumCategoria
            // 
            this.ColumCategoria.HeaderText = "Categoría";
            this.ColumCategoria.Name = "ColumCategoria";
            // 
            // ColumnProvedor
            // 
            this.ColumnProvedor.HeaderText = "Proveedor";
            this.ColumnProvedor.Name = "ColumnProvedor";
            // 
            // ColumOrden
            // 
            this.ColumOrden.HeaderText = "Orden";
            this.ColumOrden.Name = "ColumOrden";
            // 
            // ColumnProducto
            // 
            this.ColumnProducto.HeaderText = "Producto";
            this.ColumnProducto.Name = "ColumnProducto";
            // 
            // ColumStock
            // 
            this.ColumStock.HeaderText = "Stock";
            this.ColumStock.Name = "ColumStock";
            // 
            // ColmAlerta
            // 
            this.ColmAlerta.HeaderText = "Generar Alerta";
            this.ColmAlerta.Name = "ColmAlerta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(356, 139);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar ";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGenerarAlerta
            // 
            this.btnGenerarAlerta.Location = new System.Drawing.Point(454, 380);
            this.btnGenerarAlerta.Name = "btnGenerarAlerta";
            this.btnGenerarAlerta.Size = new System.Drawing.Size(102, 38);
            this.btnGenerarAlerta.TabIndex = 7;
            this.btnGenerarAlerta.Text = "Generar Alerta";
            this.btnGenerarAlerta.UseVisualStyleBackColor = true;
            this.btnGenerarAlerta.Click += new System.EventHandler(this.btnGenerarAlerta_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cargar Productos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txbNombreProducto
            // 
            this.txbNombreProducto.Location = new System.Drawing.Point(202, 139);
            this.txbNombreProducto.Name = "txbNombreProducto";
            this.txbNombreProducto.Size = new System.Drawing.Size(100, 23);
            this.txbNombreProducto.TabIndex = 9;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbNombreProducto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGenerarAlerta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.label1);
            this.Name = "FormProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProvedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumStock;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColmAlerta;
        private System.Windows.Forms.Button btnGenerarAlerta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbNombreProducto;
    }
}