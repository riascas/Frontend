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
    public partial class frmAgregar : Form
    {
        private readonly IAutheticationService _autheticationService;
        public frmAgregar()
        {
            _autheticationService = (IAutheticationService)Program.ServiceProvider.GetService(typeof(IAutheticationService));
            BManejadorRoles _BManejadorRoles = new BManejadorRoles();
            InitializeComponent();

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


        private void btnagregar_Click(object sender, EventArgs e)
        {
            BManejadorUsuarios _bManejadorUsuarios = new BManejadorUsuarios();
            Direccion direccion = new Direccion()
            {
                Calle = txtcalle.Text,
                Altura = txtaltura.Text,
                CodigoPostal = txtcp.Text,
                Localidad = txtlocalidad.Text,
                Provincia = txtprovincia.Text
            };

            Usuario usuario = new Usuario()
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Legajo = int.Parse(txtlegajo.Text),
                Rol = (Rol)cboxrol.SelectedItem,
                DNI = int.Parse(txtdni.Text),
                Direccion = direccion
            };



            BManejadorUsuarios manejadorUsuario = new BManejadorUsuarios();
            if (chkdesactivar.Checked==true)
            {
                try
                {
                    manejadorUsuario.activarUnUsuario(usuario);
                }
                catch(BLL_ModuloDos.Excepciones.ExcepcionErrorGenerico exep)
                {
                    MessageBox.Show(exep.Descripcion);
                }
            }
            if (chkdesactivar.Checked==true)
            {
                
                try
                {
                   manejadorUsuario.desactivarUnUsuario(usuario); 
                }
                catch (BLL_ModuloDos.Excepciones.ExcepcionErrorGenerico exepc)
                {
                    MessageBox.Show(exepc.Descripcion);
                }

            }
            
            try
            {
                _bManejadorUsuarios.altaUsuario(usuario, txtcontraseña.Text, txtconfirmarcontraseña.Text);
                MessageBox.Show("El usuario ha sido dado de alta.");
            }
            catch (BLL_ModuloDos.Excepciones.ExcepcionErrorGenerico exe)
            {
                MessageBox.Show(exe.Descripcion);
            }
            catch (BLL_ModuloDos.Excepciones.ExcepcionPassword ex)
            {
                MessageBox.Show(ex.Descripcion);
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
