using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventarioEquiposFase3N.Controllers
{
    public class EmpleadoController
    {
        private readonly RepositorioEmpleados _repositorioEmpleado;

        public EmpleadoController(RepositorioEmpleados repositorio)
        {
            _repositorioEmpleado = repositorio;
        } 

        public BindingList<Empleado> ObtenerTodos()
        {
            return _repositorioEmpleado.ObtenerTodos();
        }

        public BindingList<Empleado> Buscar(string texto) 
        {
            return _repositorioEmpleado.BuscarTexto(texto);
        }

        public void Agregar(Empleado empleado) 
        {
            if (string.IsNullOrEmpty(empleado.Dui)) 
            {
                throw new ArgumentException("El DUI no puede estar vacío");
            }

            if (string.IsNullOrEmpty(empleado.Nombre)) 
            {
                throw new ArgumentException("El nombre no puede estar vacío");
            }

            _repositorioEmpleado.Agregar(empleado);
        }

        public void Actualizar(Empleado original, Empleado copia) 
        {
            if(original == null || copia == null)
            {
                throw new ArgumentNullException("Los datos del empleado no pueden estar vacios");
            }

            if (_repositorioEmpleado.ExisteDui(copia.Dui, original)) 
            {
                throw new ArgumentException("El DUI ya existe en otro empleado");
            }

            _repositorioEmpleado.Actualizar(copia);
        }

        public void Eliminar(Empleado empleado) 
        {
            if(empleado == null)
            {
                return;
            }

            _repositorioEmpleado.Eliminar(empleado);
        }
    }
}
