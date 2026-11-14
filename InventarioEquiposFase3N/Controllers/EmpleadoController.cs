using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Repositorios;
using InventarioEquiposFase3N.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventarioEquiposFase3N.Controllers
{
    public class EmpleadoController
    {
        private readonly RepositorioEmpleados _repositorioEmpleado;
        private readonly ServicioFotoEmpleado _fotos;

        public EmpleadoController(RepositorioEmpleados repositorio, ServicioFotoEmpleado fotos)
        {
            _repositorioEmpleado = repositorio;
            _fotos = fotos;
        } 

        public BindingList<Empleado> ObtenerTodos()
        {
            return _repositorioEmpleado.ObtenerTodos();
        }

        public BindingList<Empleado> Buscar(string texto) 
        {
            return _repositorioEmpleado.BuscarTexto(texto);
        }

        public void Agregar(Empleado empleado, string? archivoFoto) 
        {
            if (string.IsNullOrEmpty(empleado.Dui)) 
            {
                throw new ArgumentException("El DUI no puede estar vacío");
            }

            if (string.IsNullOrEmpty(empleado.Nombre)) 
            {
                throw new ArgumentException("El nombre no puede estar vacío");
            }

            if (empleado.Id <= 0)
            {
                int maxId = 0;
                foreach (var emp in _repositorioEmpleado.ObtenerTodos())
                {
                    if (emp.Id > maxId)
                        maxId = emp.Id;
                }
                empleado.Id = maxId + 1; // Si el máximo era 5, este será el 6.
            }

            string? rutaCreada = null;
            try
            {
                if (archivoFoto != null) rutaCreada = _fotos.GuardarFoto(empleado.Id, archivoFoto);

                empleado.FotoRuta = rutaCreada;
                _repositorioEmpleado.Agregar(empleado);
            }
            catch 
            {
                _fotos.EliminarFoto(rutaCreada);
                empleado.FotoRuta = null;
                throw;
            }

        }

        public void Actualizar(Empleado original, Empleado copia, string? archivoFoto, bool eliminarFoto) 
        {
            if(original == null || copia == null)
            {
                throw new ArgumentNullException("Los datos del empleado no pueden estar vacios");
            }

            if (_repositorioEmpleado.ExisteDui(copia.Dui, original)) 
            {
                throw new ArgumentException("El DUI ya existe en otro empleado");
            }

            string? rutaFotoAnterior = original.FotoRuta;
            string? rutaNueva = null;

            try 
            {
                if (archivoFoto != null) 
                    rutaNueva = _fotos.GuardarFoto(original.Id, archivoFoto);
                copia.FotoRuta = eliminarFoto ? null : (rutaNueva ?? original.FotoRuta);
                _repositorioEmpleado.Actualizar(copia);
            }
            catch 
            {
                _fotos.EliminarFoto(rutaNueva);
                throw;
            }

            if (rutaFotoAnterior != copia.FotoRuta) 
            {
                _fotos.EliminarFoto(rutaFotoAnterior);
            }
        }

        public void Eliminar(Empleado empleado) 
        {
            if(empleado == null)
            {
                return;
            }

            _repositorioEmpleado.Eliminar(empleado);
            _fotos.EliminarFoto(empleado.FotoRuta);
        }
    }
}
