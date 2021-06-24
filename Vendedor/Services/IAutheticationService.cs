using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace Vendedor.Services
{
    public interface IAutheticationService
    {
        void Logout();
        Usuario Login(string legajo, string password);
        Usuario GetUsuario();
    }
}
