using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL_Modulo3;
using System.Linq;
using Vendedor.DisplayClass;
using Entidades;
using Vendedor.Services;


namespace Vendedor
{
    public partial class frmOrdenVenta : Form
    {
        List<DetalleDeCompraDisplay> displayProducts = new List<DetalleDeCompraDisplay>();
        List<DetalleOrden> listaDetalles = new List<DetalleOrden>();
        private readonly IAutheticationService _autheticationService;
        Cliente cliente1;
        List<MetodoDePago> metodoDePagos = new List<MetodoDePago>();
        Tarjeta tarjeta = new Tarjeta();
        Efectivo efectivo = new Efectivo();

        public frmOrdenVenta(Cliente cliente)
        {
            _autheticationService = (IAutheticationService)Program.ServiceProvider.GetService(typeof(IAutheticationService));
            InitializeComponent();
            cmbMetodopago.Items.Add("Efectivo");
            cmbMetodopago.Items.Add("Tarjeta");
            cmbMetodopago.SelectedIndex = 0;
            txbNombreTarjeta.Visible = false;
            txbFechaTarjeta.Visible = false;
            txbNumeroTarjeta.Visible = false;
            txbCvc.Visible = false;
            cliente1 = cliente;

        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = ProductoBLL.BuscarProducto(txbProducto.Text).FirstOrDefault();
                string validacion = ValidateProductoCantidad(producto, txbCantidad.Text, txbProducto.Text);

                if (!string.IsNullOrEmpty(validacion))
                {
                    MessageBox.Show(validacion);
                    return;
                }

                dtgvProductos.AutoGenerateColumns = false;
                DetalleDeCompraDisplay detalleDeCompraDisplay = new DetalleDeCompraDisplay(producto, int.Parse(txbCantidad.Text));
                DetalleOrden detalleOrden = new DetalleOrden();
                detalleOrden.Producto = producto;
                detalleOrden.Cantidad = int.Parse(txbCantidad.Text);
                listaDetalles.Add(detalleOrden);
                displayProducts.Add(detalleDeCompraDisplay);
                dtgvProductos.DataSource = new System.Windows.Forms.BindingSource { DataSource = displayProducts };
            }
            catch (BLL_Modulo3.EXCEPCIONES.ExcepcionesNegocio exep)
            {
                MessageBox.Show(exep.Descripcion);
            } 
        }

        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                dtgvProductos.Rows.RemoveAt(senderGrid.CurrentRow.Index);
            }
        }
        private void cmbMetodopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodopago.Text == "Tarjeta")
            {
                txbNombreTarjeta.Visible = true;
                txbFechaTarjeta.Visible = true;
                txbNumeroTarjeta.Visible = true;
                txbCvc.Visible = true;
                lblNombreTarjet.Visible = true;
                lblFechaTarjeta.Visible = true;
                lblNroTarjeta.Visible = true;
                lblCvcTarjeta.Visible = true;
            }
            if (cmbMetodopago.Text != "Tarjeta")
            {
                txbNombreTarjeta.Visible = false;
                txbFechaTarjeta.Visible = false;
                txbNumeroTarjeta.Visible = false;
                txbCvc.Visible = false;
                lblNombreTarjet.Visible = false;
                lblFechaTarjeta.Visible = false;
                lblNroTarjeta.Visible = false;
                lblCvcTarjeta.Visible = false;
            }
        }

        private void btnGuardarOrden_Click(object sender, EventArgs e)
        {
            OrdenDeVenta ordenDeventa = new OrdenDeVenta();
            if (cmbMetodopago.Text == "Tarjeta")
            {
                tarjeta.CVC = txbCvc.Text;
                tarjeta.NumeroTarjeta = txbNumeroTarjeta.Text;
                tarjeta.NombreTarjeta = txbNombreTarjeta.Text;
                tarjeta.FechaVencimiento = txbFechaTarjeta.Text;
                ordenDeventa.MetodoDePago = tarjeta;
            }
            if(cmbMetodopago.Text == "Efectivo")
            {
                ordenDeventa.MetodoDePago = efectivo;
            }
            ordenDeventa.Cliente = cliente1;
           
            ordenDeventa.UsuarioCreador = _autheticationService.GetUsuario();
            if (listaDetalles.Count > 0)
            {
                ordenDeventa.Detalles = listaDetalles;
                try
                {
                    VentaBLL.GuardaOrdenVenta(ordenDeventa);
                    MessageBox.Show("Orden guardada exitosamente");
                }
                catch (BLL_Modulo3.EXCEPCIONES.ExcepcionesNegocio exep)
                {
                    MessageBox.Show(exep.Descripcion);
                }
            }
            else
            {
                MessageBox.Show("Erro:Ingrese algun producto para generar la orden de venta");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string ValidateProductoCantidad(Producto producto, string cantidad, string txbProducto)
        {
            if ((producto == null || txbProducto == "") && !int.TryParse(txbCantidad.Text, out int num))
            {
                return "Producto y cantidad invalidos.";
            }
            else if (producto == null)
            {
                return "Producto invalido .";
            }
            else if (!int.TryParse(txbCantidad.Text, out int num2))
            {
                return "Cantidad invalida.";
            }
            else if (!producto.Nombre.Contains(txbProducto) || txbProducto == "")
            {
                return "Producto invalida.";
            }
            else
            {
                return null;
            }
        }


    }
}
