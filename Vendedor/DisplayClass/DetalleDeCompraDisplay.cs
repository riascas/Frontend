using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace Vendedor.DisplayClass
{
    public class DetalleDeCompraDisplay : Producto
    {

        public DetalleDeCompraDisplay(Producto producto, int cantidad)
        {
            Nombre = producto.Nombre;
            PrecioVenta = producto.PrecioVenta;
            Cantidad = cantidad;
            PrecioTotal = producto.PrecioVenta * cantidad;
            ID = producto.ID;
        }

        public int Cantidad { get; set; }
        public float PrecioTotal { get; set; }
        public bool Delete { get; set; }
    }

    
}
