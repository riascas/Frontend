using BLL_ModuloDos;
using Entidades;
using System;
using System.Windows.Forms;
using Vendedor;
using Vendedor.Services;

namespace LoginAdministradorFront
{
    public partial class frmLogin : Form
    {
        private readonly IAutheticationService _autheticationService;
        public frmLogin()
        {
            _autheticationService = (IAutheticationService)Program.ServiceProvider.GetService(typeof(IAutheticationService));
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
             _autheticationService.Login(txtboxlegajo.Text.ToString(), txtboxcontraseña.Text.ToString());
            switch (Entidades.ManejadorDeSesion.Sesion.Usuario.Rol.Descripcion)
            {
                //el combobox devuelve numeros del 1 al 4 para representar roles
                case "Administrador":
                    new frmAdministrador().Show();
                    break;
                case "Encargado de inventario y logistica":
                    //   new frmEncargado().Show();
                    break;
                case "Vendedor":
                    new frmClientes().Show();

                    //Usuario usuario =  ManejadorDeSesion.Sesion.Usuario;
                    break;
                case "Gerente":
                    //  new frmGerente().Show();
                    break;
                default:
                    MessageBox.Show("No se eligio un rol");
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
