
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGenerarAlerta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colprecio_ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrec_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblProductos.Location = new System.Drawing.Point(125, 140);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(59, 15);
            this.lblProductos.TabIndex = 3;
            this.lblProductos.Text = "Producto:";
            this.lblProductos.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(588, 136);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Categoría:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(188, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColCategoria,
            this.ColumStock,
            this.Colprecio_ven,
            this.ColPrec_venta});
            this.dataGridView1.Location = new System.Drawing.Point(122, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(544, 90);
            this.dataGridView1.TabIndex = 13;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            // 
            // ColCategoria
            // 
            this.ColCategoria.HeaderText = "Categoría";
            this.ColCategoria.Name = "ColCategoria";
            // 
            // ColumStock
            // 
            this.ColumStock.HeaderText = "Stock";
            this.ColumStock.Name = "ColumStock";
            // 
            // Colprecio_ven
            // 
            this.Colprecio_ven.HeaderText = "Precio Compra";
            this.Colprecio_ven.Name = "Colprecio_ven";
            // 
            // ColPrec_venta
            // 
            this.ColPrec_venta.HeaderText = "Precio Venta";
            this.ColPrec_venta.Name = "ColPrec_venta";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGenerarAlerta);
            this.Controls.Add(this.btnBuscar);
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGenerarAlerta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colprecio_ven;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrec_venta;
    }
}