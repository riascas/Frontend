using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace Vendedor.DisplayClass
{
    public class ClienteDisplay
    {
        public ClienteDisplay(Cliente cliente)
        {
            this.Nombre = cliente.Nombre;
            this.Apellido = cliente.Apellido;
            this.DNI = cliente.DNI;
            this.Provincia = cliente.Direccion.Provincia;
            this.Localidad = cliente.Direccion.Localidad;
            this.Calle = cliente.Direccion.Calle;
            this.Altura = cliente.Direccion.Altura;
            this.Cp = cliente.Direccion.CodigoPostal;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string Calle { get; set; }
        public string Altura { get; set; }
        public string Cp { get; set; }
    }
}
