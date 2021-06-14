using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_ModuloDos;
using DAL_ModuloDos;
using Entidades;

namespace LoginAdministradorFront
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            BManejadorRoles _BManejadorRoles = new BManejadorRoles();

            List<Rol> roles = _BManejadorRoles.obtenerRoles();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = roles;

            foreach (Rol unrol in roles)
            {

                cboxrol.DataSource = bindingSource1.DataSource;
                cboxrol.DisplayMember = "Descripcion";

            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            BAutenticacion _autenticacionUsuario;
            _autenticacionUsuario = new BAutenticacion();

            _autenticacionUsuario.Login(txtboxlegajo.Text, txtboxcontraseña.Text);
            switch (int.Parse(cboxrol.Text))
            {
                //el combobox devuelve numeros del 1 al 4 para representar roles
                case 1:
                    new frmAdministrador().Show();
                break;
                case 2:
                    new frmEncargado().Show();
                    break;
                case 3:
                     new frmVendedor().Show();
                break;
                case 4:
                    new frmGerente().Show();
                    break;
                default:
                    MessageBox.Show("No se eligio un rol");
                    break;
            }
        }
    }
}
