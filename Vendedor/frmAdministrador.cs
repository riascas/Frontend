using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginAdministradorFront
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            new frmAgregar().Show();
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            new frmEditar().Show();
            this.Close();
        }
    }
}
