using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Repositorios;

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
            var repositorioEmpleado = new RepositorioEmpleados();
            var empleadoController = new EmpleadoController(repositorioEmpleado);
            var repositorioEquipos = new RepositorioEquipos();
            var equiposController = new EquiposController(repositorioEquipos);
            var repositorioAsignacion = new RepositorioAsignaciones(repositorioEquipos, repositorioEmpleado);
            var asignacionController = new AsignacionController(repositorioAsignacion, repositorioEquipos, repositorioEmpleado);
            var repositorioDepartamentos = new RepositorioDepartamentos();
            var departamentosController = new DepartamentosController(repositorioDepartamentos);

            Application.Run(new frmPrincipal(empleadoController, equiposController, asignacionController, repositorioEquipos, departamentosController));

        }
    }
}