using BLL_Modulo3;
using DAL_Modulo3;
using BLL_ModuloDos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vendedor.DisplayClass;
using System.Linq;
using Vendedor.Services;

namespace Vendedor
{
    public partial class frmClientes : Form
    {
        private List<ClienteDisplay> listaClienteDisplay;
        private readonly IAutheticationService _autheticationService;
        public frmClientes()
        {
            listaClienteDisplay = new List<ClienteDisplay>();
            _autheticationService = (IAutheticationService)Program.ServiceProvider.GetService(typeof(IAutheticationService));

            //autenticacion = autenticacion1;
            InitializeComponent();
            List<Cliente> clientes = ClienteBLL.BuscarClientesPorDNI("");
            foreach (Cliente cliente in clientes)
            {
                var clienteDisplay = new ClienteDisplay(cliente);
                listaClienteDisplay.Add(clienteDisplay);
            }
            dtgvClientes.AutoGenerateColumns = false;
            dtgvClientes.DataSource = new System.Windows.Forms.BindingSource { DataSource = listaClienteDisplay };
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //Busco cliente por dni utilizando la clase cliente display para mostrar correctamenet los datos en el dtgv
            dtgvClientes.Rows.Clear();
            try
            {
                List<Cliente> clientes = ClienteBLL.BuscarClientesPorDNI(txbIngreseDni.Text);
                foreach (Cliente cliente in clientes)
                {
                    var clienteDisplay = new ClienteDisplay(cliente);
                    listaClienteDisplay.Add(clienteDisplay);
                }
                dtgvClientes.AutoGenerateColumns = false;
                dtgvClientes.DataSource = new System.Windows.Forms.BindingSource { DataSource = listaClienteDisplay };
            }
            catch (BLL_Modulo3.EXCEPCIONES.ExcepcionesNegocio exep)
            {
                MessageBox.Show(exep.Descripcion);
            }
        }
        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                    txbNombre.Text = listaClienteDisplay[senderGrid.CurrentRow.Index].Nombre;
                    txbApellido.Text = listaClienteDisplay[senderGrid.CurrentRow.Index].Apellido;
                    txbDni.Text = listaClienteDisplay[senderGrid.CurrentRow.Index].DNI.ToString();
                    txbProvincia.Text = listaClienteDisplay[senderGrid.CurrentRow.Index].Provincia;
                    txbLocalidad.Text = listaClienteDisplay[senderGrid.CurrentRow.Index].Localidad;
                    txbCalle.Text = listaClienteDisplay[senderGrid.CurrentRow.Index].Calle;
                    txbAltura.Text = listaClienteDisplay[senderGrid.CurrentRow.Index].Altura;
                    txbCp.Text = listaClienteDisplay[senderGrid.CurrentRow.Index].Cp;
            }
        }
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            var textBoxCollection = new[] { txbNombre,txbApellido,txbDni,txbDni,txbProvincia,txbLocalidad,txbCalle,txbAltura,txbCp };
            bool camposCompletos = textBoxCollection.Any(t => String.IsNullOrWhiteSpace(t.Text));
            if(camposCompletos == false)
            {
                GuardarEditarCliente();
                dtgvClientes.Rows.Clear();
                List<Cliente> clientes = ClienteBLL.BuscarClientesPorDNI("");
                foreach (Cliente cliente in clientes)
                {
                    var clienteDisplay = new ClienteDisplay(cliente);
                    listaClienteDisplay.Add(clienteDisplay);
                }
                dtgvClientes.AutoGenerateColumns = false;
                dtgvClientes.DataSource = new System.Windows.Forms.BindingSource { DataSource = listaClienteDisplay };
            }
            else
            {
                MessageBox.Show("Complete todos los campos porfavor");
            }
            
        }

        private void btnOrdenDeVenta_Click(object sender, EventArgs e)
        {
            Cliente cliente = ClienteBLL.BuscarClientesPorDNI(txbDni.Text).FirstOrDefault();
            if(cliente != null)
            {
                frmOrdenVenta frmOrdenVenta = new frmOrdenVenta(cliente);
                frmOrdenVenta.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente existente o Crearlo para poder avanzar");
            }
        }
        public void GuardarEditarCliente()
        {
            Cliente clienteModificado = new Cliente();
            clienteModificado.Direccion = new Direccion();
            clienteModificado.Nombre = txbNombre.Text;
            clienteModificado.Apellido = txbApellido.Text;
            clienteModificado.DNI = int.Parse(txbDni.Text);
            clienteModificado.Direccion.Provincia = txbProvincia.Text;
            clienteModificado.Direccion.Localidad = txbLocalidad.Text;
            clienteModificado.Direccion.Altura = txbAltura.Text;
            clienteModificado.Direccion.CodigoPostal = txbCp.Text;
            clienteModificado.Direccion.Calle = txbCalle.Text;
            Cliente cliente = ClienteBLL.BuscarClientesPorDNI(txbDni.Text).FirstOrDefault();
            if (cliente != null)
            {
                try
                {
                  ClienteBLL.ModificarUnCliente(cliente, clienteModificado);
                  MessageBox.Show("Cliente modificado con exito");
                }
                catch (BLL_Modulo3.EXCEPCIONES.ExcepcionesNegocio exep)
                {
                    MessageBox.Show(exep.Descripcion);
                }
                
            }
            else
            {
                try
                {
                    ClienteBLL.GuardarCliente(clienteModificado);
                    MessageBox.Show("Cliente creado con exito");
                }
                catch (BLL_Modulo3.EXCEPCIONES.ExcepcionesNegocio exep)
                {
                    MessageBox.Show(exep.Descripcion);
                }
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
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
        private void txbIngreseDni_Click(object sender, EventArgs e)
        {
            txbIngreseDni.Clear();
        }
    }
}
