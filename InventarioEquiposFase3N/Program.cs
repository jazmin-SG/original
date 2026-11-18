using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Repositorios;
using InventarioEquiposFase3N.Services;

namespace InventarioEquiposFase3N
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string carpetaDatos = AppContext.BaseDirectory;
            var servicioFotos = new ServicioFotoEmpleado(carpetaDatos);
            var repositorioEmpleado = new RepositorioEmpleados();
            var empleadoController = new EmpleadoController(repositorioEmpleado, servicioFotos);
            var repositorioEquipos = new RepositorioEquipos();
            var equiposController = new EquiposController(repositorioEquipos);
            var repositorioAsignacion = new RepositorioAsignaciones(repositorioEquipos, repositorioEmpleado);
            repositorioAsignacion.Leer();
            var asignacionController = new AsignacionController(repositorioAsignacion, repositorioEquipos, repositorioEmpleado);
            var repositorioDepartamentos = new RepositorioDepartamentos();
            var departamentosController = new DepartamentosController(repositorioDepartamentos);
            var repositorioMantenimientos = new RepositorioMantenimientos();
            var mantenimientoController = new MantenimientoController(repositorioMantenimientos);

            Application.Run(new frmPrincipal(empleadoController, equiposController, asignacionController, repositorioEquipos, departamentosController, servicioFotos, mantenimientoController));

        }
    }
}