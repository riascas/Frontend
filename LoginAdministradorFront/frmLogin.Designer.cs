
namespace LoginAdministradorFront
{
    partial class frmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxlegajo = new System.Windows.Forms.TextBox();
            this.txtboxcontraseña = new System.Windows.Forms.TextBox();
            this.cboxrol = new System.Windows.Forms.ComboBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Legajo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol";
            // 
            // txtboxlegajo
            // 
            this.txtboxlegajo.Location = new System.Drawing.Point(210, 115);
            this.txtboxlegajo.Name = "txtboxlegajo";
            this.txtboxlegajo.Size = new System.Drawing.Size(121, 23);
            this.txtboxlegajo.TabIndex = 4;
            // 
            // txtboxcontraseña
            // 
            this.txtboxcontraseña.Location = new System.Drawing.Point(210, 191);
            this.txtboxcontraseña.Name = "txtboxcontraseña";
            this.txtboxcontraseña.Size = new System.Drawing.Size(121, 23);
            this.txtboxcontraseña.TabIndex = 5;
            // 
            // cboxrol
            // 
            this.cboxrol.FormattingEnabled = true;
            this.cboxrol.Location = new System.Drawing.Point(210, 274);
            this.cboxrol.Name = "cboxrol";
            this.cboxrol.Size = new System.Drawing.Size(121, 23);
            this.cboxrol.TabIndex = 6;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(319, 343);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(141, 34);
            this.btningresar.TabIndex = 7;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-2, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 405);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.cboxrol);
            this.Controls.Add(this.txtboxcontraseña);
            this.Controls.Add(this.txtboxlegajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxlegajo;
        private System.Windows.Forms.TextBox txtboxcontraseña;
        private System.Windows.Forms.ComboBox cboxrol;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Panel panel1;
    }
}

