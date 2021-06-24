using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginAdministradorFront;
using Microsoft.Extensions.DependencyInjection;
using Vendedor.Services;

namespace Vendedor
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new frmLogin());
        }
        
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            //Creo un servicio de unica instancia
            services.AddTransient<IAutheticationService, AuthenticationService>();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
