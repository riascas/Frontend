using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using ENTITY;
using Vendedor.DisplayClass;

namespace Vendedor
{
    public partial class frmVendedor : Form
    {
        private List<DetalleCompraDisplay> displayProducts;
        public frmVendedor()
        {
            displayProducts = new List<DetalleCompraDisplay>();
            InitializeComponent();
        }

        

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            txbNombreCliente.Clear();
            txbApellidoCliente.Clear();
            txbDniCliente.Clear();
            txbLocalidadCliente.Clear();
            txbProvinciaCliente.Clear();
            txtCalleCliente.Clear();
            txbAlturaCliente.Clear();
            txbCpCliente.Clear();

            //List<Cliente> listaClientes = new List<Cliente>();
            List <Cliente> listaClientes = BLL.ClienteBLL.BuscarClientesPorDNI(txbIngreseDni.Text);
            if (listaClientes.Count == 0)
            {
                MessageBox.Show("Error usted ingresó el DNI de forma incorrecta o el cliente no existe y debe cargar sus datos");

            }
            else
            {
                foreach(Cliente cliente in listaClientes)
                {
                    txbNombreCliente.Text = cliente.Nombre;
                    txbApellidoCliente.Text = cliente.Apellido;
                    txbDniCliente.Text = cliente.DNI;
                    txbLocalidadCliente.Text = cliente.Direccion.Localidad;
                    txbProvinciaCliente.Text = cliente.Direccion.Provincia;
                    txtCalleCliente.Text = cliente.Direccion.Calle;
                    txbAlturaCliente.Text = cliente.Direccion.Altura;
                    txbCpCliente.Text = cliente.Direccion.CodigoPostal;
                }
            }
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            guardarEditarCliente();

        }
        
        private Cliente guardarEditarCliente()
        {
            Cliente clienteModificado = new Cliente();
            clienteModificado.Direccion = new Direccion();
            clienteModificado.Nombre = txbNombreCliente.Text;
            clienteModificado.Apellido = txbApellidoCliente.Text;
            clienteModificado.DNI = txbDniCliente.Text;
            clienteModificado.Direccion.Provincia = txbProvinciaCliente.Text;
            clienteModificado.Direccion.Localidad = txbLocalidadCliente.Text;
            clienteModificado.Direccion.Altura = txbAlturaCliente.Text;
            clienteModificado.Direccion.CodigoPostal = txbCpCliente.Text;
            clienteModificado.Direccion.Calle = txtCalleCliente.Text;
            Cliente cliente = ClienteBLL.BuscarClientesPorDNI(txbDniCliente.Text).FirstOrDefault();
            if (cliente != null)
            {
                ClienteBLL.ModificarUnCliente(cliente, clienteModificado);
            }
            else
            {
                ClienteDAL.Alta(clienteModificado);
            }
            return clienteModificado;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = ProductoBLL.BuscarProducto(txbNombreProducto.Text).FirstOrDefault();

            if (producto == null)
            {
                MessageBox.Show("Producto Inexistente");
            }

            dtgvProducto.AutoGenerateColumns = false;

            int cantidad;

            if (!int.TryParse(txbCantidad.Text, out cantidad))
            {
                MessageBox.Show("Cantidad Invalida");
            }

            var newDetalleCompra = new DetalleCompraDisplay(producto, cantidad);

            displayProducts.Add(newDetalleCompra);
            dtgvProducto.DataSource = new System.Windows.Forms.BindingSource { DataSource = displayProducts };
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            displayProducts = displayProducts.Where(x => !x.Delete).ToList();
            dtgvProducto.DataSource = displayProducts;
        }

        private void txbIngreseDni_Click(object sender, EventArgs e)
        {
            txbIngreseDni.Clear();
        }

        private void txbNombreProducto_Click(object sender, EventArgs e)
        {
            txbNombreProducto.Clear();
        }

        private void txbNroTarjeta_Click(object sender, EventArgs e)
        {
            txbNroTarjeta.Clear();
        }

        private void txtFechaTarjeta_Click(object sender, EventArgs e)
        {
            txtFechaTarjeta.Clear();
        }

        private void txbNombreTarjeta_Click(object sender, EventArgs e)
        {
            txbNombreTarjeta.Clear();
        }

        private void txbCvcTarjeta_Click(object sender, EventArgs e)
        {
            txbCvcTarjeta.Clear();
        }

        private void dtgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                displayProducts[e.RowIndex].Delete = !displayProducts[e.RowIndex].Delete;
            }
        }

        private void btnGuardarOrden_Click(object sender, EventArgs e)
        {
            var items = new List<DetalleOrden>();
            this.displayProducts.ForEach(displayProduct => {
                items.Add(displayProduct.ParseToDetalleOrden());
            });

            OrdenDeVenta ordenDeVenta = new OrdenDeVenta();
            ordenDeVenta.Detalles = items;

            Tarjeta tarjeta = new Tarjeta();
            tarjeta.NombreTarjeta = txbNombreTarjeta.Text;
            tarjeta.NumeroTarjeta = txbNroTarjeta.Text;
            tarjeta.CVC = txbCvcTarjeta.Text;

            Cliente cliente = guardarEditarCliente();

            ordenDeVenta.Cliente = cliente;
            ordenDeVenta.MetodoDePago = tarjeta;
            ordenDeVenta.UsuarioCreador = new Usuario();
            ordenDeVenta.UsuarioCreador.Legajo = 1;
            OrdenDeVentaBLL.GuardaOrdenVenta(ordenDeVenta); 
        }
    }
}
