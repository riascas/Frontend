using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL_ModuloDos;
using DAL_ModuloDos;
using Entidades;
using Vendedor;
using Vendedor.Services;

namespace LoginAdministradorFront
{
    public partial class frmEditar : Form
    {
        private readonly IAutheticationService _autheticationService;
        public frmEditar()
        {
            _autheticationService = (IAutheticationService)Program.ServiceProvider.GetService(typeof(IAutheticationService));
            InitializeComponent();

            BManejadorRoles _BManejadorRoles = new BManejadorRoles();

            try
            {
                List<Rol> roles = _BManejadorRoles.obtenerRoles();
                cboxrol.DataSource = roles;
                cboxrol.DisplayMember = "Descripcion";


            }
            catch (BLL_ModuloDos.Excepciones.ExcepcionErrorGenerico exepc)
            {
                MessageBox.Show(exepc.Descripcion);
            }

            

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            BManejadorUsuarios _bManejadorUsuarios = new BManejadorUsuarios();
            usuarioAModificar.Nombre = txtboxnombre.Text;
            usuarioAModificar.Apellido = txtboxapellido.Text;
            usuarioAModificar.DNI = int.Parse(txtboxdni.Text);
            usuarioAModificar.Direccion.CodigoPostal = txtboxcp.Text;
            usuarioAModificar.Direccion.Provincia = txtboxprovincia.Text;
            usuarioAModificar.Direccion.Localidad = txtboxlocalidad.Text;
            usuarioAModificar.Direccion.Calle = txtboxcalle.Text;
            usuarioAModificar.Direccion.Altura = txtboxaltura.Text;
            usuarioAModificar.Legajo = int.Parse(txtboxlegajo.Text);
            usuarioAModificar.Rol = (Rol)cboxrol.SelectedItem;


            BManejadorUsuarios manejadorUsuario = new BManejadorUsuarios();
            if (chkboxalta.Checked == true)
            {
                try
                {
                    manejadorUsuario.activarUnUsuario(usuarioAModificar);
                }
                catch (BLL_ModuloDos.Excepciones.ExcepcionErrorGenerico exep)
                {
                    MessageBox.Show(exep.Descripcion);
                }
            }
            if (chkboxbaja.Checked == true)
            {

                try
                {
                    manejadorUsuario.desactivarUnUsuario(usuarioAModificar);
                }
                catch (BLL_ModuloDos.Excepciones.ExcepcionErrorGenerico exepc)
                {
                    MessageBox.Show(exepc.Descripcion);
                }

            }


            try
            {
                _bManejadorUsuarios.modicarUsuario(usuarioAModificar);
                MessageBox.Show("El usuario ha sido modificado");
            }
            catch (BLL_ModuloDos.Excepciones.ExcepcionErrorGenerico ex)
            {
                MessageBox.Show(ex.Descripcion);
            }
        }


        BManejadorUsuarios _bManejadorUsuarios = new BManejadorUsuarios();
        Usuario usuarioAModificar;
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            List<Usuario> _usuarios = _bManejadorUsuarios.obtenerListaUsuarios();
            foreach (Usuario _unUsuario in _usuarios)
            {
                if (int.Parse(txtboxdnibuscar.Text) == _unUsuario.DNI)
                {
                    txtboxnombre.Text = _unUsuario.Nombre.ToString();
                    txtboxapellido.Text = _unUsuario.Apellido.ToString();
                    txtboxdni.Text = _unUsuario.DNI.ToString();
                    txtboxcp.Text = _unUsuario.Direccion.CodigoPostal.ToString();
                    txtboxprovincia.Text = _unUsuario.Direccion.Provincia.ToString();
                    txtboxlocalidad.Text = _unUsuario.Direccion.Localidad.ToString();
                    txtboxcalle.Text = _unUsuario.Direccion.Calle.ToString();
                    txtboxaltura.Text = _unUsuario.Direccion.Altura.ToString();
                    txtboxlegajo.Text = _unUsuario.Legajo.ToString();
                    cboxrol.Text = _unUsuario.Rol.Descripcion;
                    usuarioAModificar = _unUsuario;
                }
            }
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            try
            {
                _autheticationService.Logout();
                this.Close();
            }
            catch (BLL_ModulosDos.Excepciones.ExcepcionBase exep)
            {
                MessageBox.Show(exep.Descripcion);
            }
        }
    }
}
