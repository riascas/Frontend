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
            txbCvc.MaxLength = 3;
            txbFechaTarjeta.MaxLength = 4;
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
                string productoNombre = dtgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtgvProductos.Rows.RemoveAt(senderGrid.CurrentRow.Index);
                DetalleOrden detalleOrden = listaDetalles.FirstOrDefault(p => p.Producto.Nombre == productoNombre);
                if (detalleOrden != null) {
                    listaDetalles.Remove(detalleOrden);
                }  
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
            bool camposTarjetaCompletos = false;
            if (cmbMetodopago.Text == "Tarjeta")
            {
                tarjeta.CVC = txbCvc.Text;
                tarjeta.NumeroTarjeta = txbNumeroTarjeta.Text;
                tarjeta.NombreTarjeta = txbNombreTarjeta.Text;
                tarjeta.FechaVencimiento = txbFechaTarjeta.Text;
                var textBoxCollection = new[] { txbNumeroTarjeta, txbCvc, txbNombreTarjeta, txbFechaTarjeta};
                camposTarjetaCompletos = textBoxCollection.Any(t => String.IsNullOrWhiteSpace(t.Text));
                if (camposTarjetaCompletos == false)
                {
                    ordenDeventa.MetodoDePago = tarjeta;
                }
                else
                    MessageBox.Show("Complete todos los datos de la tarjeta");
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
                if (camposTarjetaCompletos == false)
                {
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
            }
            else
            {
                MessageBox.Show("Error: Ingrese algun producto para generar la orden de venta");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e, txbCantidad);
        }

        private void txbNumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e, txbNumeroTarjeta);
        }

        private void txbFechaTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e, txbFechaTarjeta);
        }

        private void txbCvc_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e, txbCvc);
        }

        public string ValidateProductoCantidad(Producto producto, string cantidad, string txbProducto)
        {
            if ((producto == null || txbProducto == "") && cantidad == "")
            {
                return "Producto y cantidad invalidos.";
            }
            else if (producto == null)
            {
                return "Producto invalido .";
            }
            else if (cantidad == "")
            {
                return "Cantidad invalida.";
            }
            else if (!producto.Nombre.Contains(txbProducto) || txbProducto == "")
            {
                return "Producto invalido.";
            }
            else
            {
                return null;
            }
        }

        public void soloNumeros(object sender, KeyPressEventArgs e, TextBox txb)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txb, "No se admiten letras solo numeros");
            }
            else
                errorProvider1.Clear();
        }
    }
}
