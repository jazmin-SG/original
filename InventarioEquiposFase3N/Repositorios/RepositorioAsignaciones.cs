using InventarioEquiposFase3N.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioEquiposFase3N.Repositorios
{
    public class RepositorioAsignaciones : RepositorioBase<Asignacion>
    {
        private readonly RepositorioEquipos _repositorioEquipos;
        private readonly RepositorioEmpleados _repositorioEmpleados;

        public RepositorioAsignaciones(RepositorioEquipos equipos, RepositorioEmpleados empleados, string? carpetaDatos = null)
            : base(Path.Combine(carpetaDatos ?? "CarpetaPredeterminada", "asignaciones.json"))
        {
            _repositorioEquipos = equipos ?? throw new ArgumentNullException(nameof(equipos));
            _repositorioEmpleados = empleados ?? throw new ArgumentNullException(nameof(empleados));
        }

        public override void Agregar(Asignacion entidad)
        {
           
            var asignacionActiva = ObtenerTodos().FirstOrDefault(a =>
                a.Empleado == entidad.Empleado &&
                a.FechaDevolucion.Date >= DateTime.Today); 

            if (asignacionActiva != null)
            {

                throw new InvalidOperationException(
                    $"El empleado ya tiene el equipo '{asignacionActiva.Equipo}' asignado hasta el {asignacionActiva.FechaDevolucion:dd/MM/yyyy}. " +
                    $"Debe registrar la devolución antes de asignarle uno nuevo.");
            }

          
            var equipoOcupado = ObtenerTodos().FirstOrDefault(a =>
                a.Equipo == entidad.Equipo &&
                a.FechaDevolucion.Date >= DateTime.Today);

            if (equipoOcupado != null)
            {

                throw new InvalidOperationException(
                    $"El equipo '{entidad.Equipo}' ya está asignado al empleado '{equipoOcupado.Empleado}'.");
            }

            if (!_repositorioEmpleados.ObtenerTodos().Any(e => e.Nombre == entidad.Empleado)) 
            {
                throw new InvalidOperationException("El empleado seleccionado no existe.");
            }

            var equipo = _repositorioEquipos.ObtenerTodos().FirstOrDefault(e => e.Codigo == entidad.Equipo); 
            if (equipo == null)
            {
                throw new InvalidOperationException("El equipo seleccionado no existe.");
            }
            

            
            base.Agregar(entidad);
        }
        public override void Actualizar(Asignacion entidad)
        {


            var empleadoOcupado = ObtenerTodos()
       .FirstOrDefault(a => a.Empleado == entidad.Empleado && a.IdAsignacion != entidad.IdAsignacion);

            if (empleadoOcupado != null)
                throw new InvalidOperationException(
                    $"El empleado ya tiene el equipo '{empleadoOcupado.Equipo}'");

            var equipoAsignado = ObtenerTodos()
                .FirstOrDefault(a => a.Equipo == entidad.Equipo && a.IdAsignacion != entidad.IdAsignacion);

            if (equipoAsignado != null)
                throw new InvalidOperationException(
                    $"Este equipo ya está asignado al empleado: '{equipoAsignado.Empleado}'");

            base.Actualizar(entidad);
        }
    }

}

