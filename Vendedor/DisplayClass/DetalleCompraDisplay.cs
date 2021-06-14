using ENTITY;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vendedor.DisplayClass
{
    public class DetalleCompraDisplay : Producto
    {
        public int Cantidad { get; set; }
        public float PrecioTotal { get; set; }
        public bool Delete { get; set; }

        public DetalleCompraDisplay(Producto producto, int cantidad)
        {
            Nombre = producto.Nombre;
            PrecioVenta = producto.PrecioVenta;
            Cantidad = cantidad;
            PrecioTotal = producto.PrecioVenta * cantidad;
            ID = producto.ID;
        }

        public DetalleOrden ParseToDetalleOrden()
        {
            var result = new DetalleOrden();
            result.Producto = this;
            result.Cantidad = this.Cantidad;

            return result;
        }
    }
}
