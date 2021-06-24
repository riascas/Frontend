using System;
using System.Collections.Generic;
using System.Text;
using BLL_ModuloDos;
using Entidades;

namespace Vendedor.Services
{
    public class AuthenticationService : IAutheticationService
    {
        private BAutenticacion autenticacion;
        static Usuario usuario;

        public AuthenticationService()
        {
            autenticacion = new BAutenticacion();
        }

        public void Logout()
        {
            autenticacion.Logout();
        }

        public Usuario Login(string legajo, string password)
        {
            autenticacion.Login(legajo, password);
            usuario = ManejadorDeSesion.Sesion.Usuario;
            return usuario;
        }

        public Usuario GetUsuario()
        {
            return usuario;
        }
    }
}
