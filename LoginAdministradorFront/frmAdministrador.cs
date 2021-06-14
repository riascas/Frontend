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

namespace LoginAdministradorFront
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();

            BManejadorRoles _BManejadorRoles = new BManejadorRoles();

            List<Rol> roles = _BManejadorRoles.obtenerRoles();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = roles;

            foreach (Rol unrol in roles)
            {
                //aparecen numeros en lugar de la descripcion
                cboxrol.DataSource = bindingSource1.DataSource;
                cboxrol.DisplayMember = "Descripcion";

            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            BManejadorUsuarios _bManejadorUsuarios = new BManejadorUsuarios();
            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.Nombre = txtboxnombre.Text;
            nuevoUsuario.Apellido = txtboxapellido.Text;
            nuevoUsuario.DNI = int.Parse(txtboxdni.Text);
            nuevoUsuario.Direccion.CodigoPostal = txtboxcp.Text;
            nuevoUsuario.Direccion.Provincia = txtboxprovincia.Text;
            nuevoUsuario.Direccion.Localidad = txtboxlocalidad.Text;
            nuevoUsuario.Direccion.Calle = txtboxcalle.Text;
            nuevoUsuario.Direccion.Altura = txtboxaltura.Text;
            nuevoUsuario.Legajo = int.Parse(txtboxlegajo.Text);
           
            //TO DO agregar funcionalidad elegir rol
            // nuevoUsuario.Rol = cboxrol.Text;

           //no hace falta que pida contraseña para que el administrador de un alta de usuario
            _bManejadorUsuarios.altaUsuario(nuevoUsuario,"123456","123456);
                
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            BManejadorUsuarios _bManejadorUsuarios = new BManejadorUsuarios();
            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.Nombre = txtboxnombre.Text;
            nuevoUsuario.Apellido = txtboxapellido.Text;
            nuevoUsuario.DNI = int.Parse(txtboxdni.Text);
            nuevoUsuario.Direccion.CodigoPostal = txtboxcp.Text;
            nuevoUsuario.Direccion.Provincia = txtboxprovincia.Text;
            nuevoUsuario.Direccion.Localidad = txtboxlocalidad.Text;
            nuevoUsuario.Direccion.Calle = txtboxcalle.Text;
            nuevoUsuario.Direccion.Altura = txtboxaltura.Text;
            nuevoUsuario.Legajo = int.Parse(txtboxlegajo.Text);
            // nuevoUsuario.Rol = cboxrol.Text;
            _bManejadorUsuarios.modicarUsuario(nuevoUsuario);
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            
        }

        BManejadorUsuarios _bManejadorUsuarios = new BManejadorUsuarios();
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            List<Usuario> _usuarios = _bManejadorUsuarios.obtenerListaUsuarios();
            foreach (Usuario _unUsuario in _usuarios)
            {
                if(int.Parse(txtboxdnibuscar.Text) == _unUsuario.DNI)
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
                    //TO DO no funciona obtener rol
                    cboxrol.Text = _unUsuario.Rol.ToString();
                }
            }
            
        }

        private void chkboxalta_CheckedChanged(object sender, EventArgs e)
        {
            BManejadorUsuarios _bManejadorUsuarios = new BManejadorUsuarios();
            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.Nombre = txtboxnombre.Text;
            nuevoUsuario.Apellido = txtboxapellido.Text;
            nuevoUsuario.DNI = int.Parse(txtboxdni.Text);
            nuevoUsuario.Direccion.CodigoPostal = txtboxcp.Text;
            nuevoUsuario.Direccion.Provincia = txtboxprovincia.Text;
            nuevoUsuario.Direccion.Localidad = txtboxlocalidad.Text;
            nuevoUsuario.Direccion.Calle = txtboxcalle.Text;
            nuevoUsuario.Direccion.Altura = txtboxaltura.Text;
            nuevoUsuario.Legajo = int.Parse(txtboxlegajo.Text);
            // nuevoUsuario.Rol = cboxrol.Text;

            _bManejadorUsuarios.activarUnUsuario(nuevoUsuario);

        }

        private void chkboxbaja_CheckedChanged(object sender, EventArgs e)
        {
            BManejadorUsuarios _bManejadorUsuarios = new BManejadorUsuarios();
            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.Nombre = txtboxnombre.Text;
            nuevoUsuario.Apellido = txtboxapellido.Text;
            nuevoUsuario.DNI = int.Parse(txtboxdni.Text);
            nuevoUsuario.Direccion.CodigoPostal = txtboxcp.Text;
            nuevoUsuario.Direccion.Provincia = txtboxprovincia.Text;
            nuevoUsuario.Direccion.Localidad = txtboxlocalidad.Text;
            nuevoUsuario.Direccion.Calle = txtboxcalle.Text;
            nuevoUsuario.Direccion.Altura = txtboxaltura.Text;
            nuevoUsuario.Legajo = int.Parse(txtboxlegajo.Text);
            // nuevoUsuario.Rol = cboxrol.Text;

            _bManejadorUsuarios.desactivarUnUsuario(nuevoUsuario);
        }
    }
}
