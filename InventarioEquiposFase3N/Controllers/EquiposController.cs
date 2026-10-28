using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace InventarioEquiposFase3N.Controllers
{
    public class EquiposController
    {
        private readonly RepositorioEquipos _repositorioEquipos;
        public EquiposController(RepositorioEquipos repositorioEquipos)
        {
            _repositorioEquipos = repositorioEquipos;
        }
        public BindingList<Equipo> ObtenerTodos()
        {
            return _repositorioEquipos.ObtenerTodos();
        }
        public void Agregar(Equipo equipo)
        {
          if (string.IsNullOrWhiteSpace(equipo.Codigo))
            {
                throw new ArgumentException("El código del equipo no puede estar vacío.");
            }
            if (string.IsNullOrWhiteSpace(equipo.Marca))
            {
                throw new ArgumentException("La marca del equipo no puede estar vacía.");
            }
            if (string.IsNullOrWhiteSpace(equipo.Modelo))
            {
                throw new ArgumentException("El modelo del equipo no puede estar vacío.");
            }
            if (string.IsNullOrWhiteSpace(equipo.NumeroSerie))
            {
                throw new ArgumentException("El número de serie del equipo no puede estar vacío.");
            }
            if (_repositorioEquipos.Existecodigo(equipo.Codigo))
            {
                throw new InvalidOperationException($"Ya existe un equipo con el código {equipo.Codigo}.");
            }
            if (_repositorioEquipos.ExisteNumeroSerie(equipo.NumeroSerie))
            {
                throw new InvalidOperationException($"Ya existe un equipo con el número de serie {equipo.NumeroSerie}.");
            }
            _repositorioEquipos.Agregar(equipo);
        }
        public void Eliminar(Equipo equipo)
        {
            if (equipo == null)
            {
                return;
            }
            Equipo? equipoExistente =_repositorioEquipos.BuscarPorCodigo(equipo.Codigo);
            if (equipoExistente == null)
            {
                throw new KeyNotFoundException("El equipo no existe en el inventario.");
            }
            if (equipoExistente.Estado == Estado.Asignado)
            {
                throw new InvalidOperationException("No se puede eliminar un equipo que está asignado a un empleado.");
            }
            if(equipoExistente.Estado == Estado.Mantenimiento)
            {
                throw new InvalidOperationException("No se puede eliminar un equipo que está en mantenimiento.");
            }
            
            _repositorioEquipos.Eliminar(equipo);
        }

        public void Actualizar(Equipo original, Equipo copia)
        {
            if (original == null || copia == null)
            {
                throw new ArgumentNullException(
                    "Los datos del equipo no pueden estar vacíos.");
            }
            if (_repositorioEquipos.BuscarPorCodigo(original.Codigo) == null)
            {
                throw new KeyNotFoundException(
                    "El equipo original no existe en el inventario.");
            }

            if (original.Codigo != copia.Codigo)
            {
                throw new InvalidOperationException(
                    "No se puede modificar el código del equipo.");
            }

            if (string.IsNullOrWhiteSpace(copia.Marca))
            {
                throw new ArgumentException("La marca no puede estar vacía.");
            }

            if (string.IsNullOrWhiteSpace(copia.Modelo))
            {
                throw new ArgumentException("El modelo no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(copia.NumeroSerie))
            {
                throw new ArgumentException("El número de serie no puede estar vacío.");
            }

            if (original.NumeroSerie != copia.NumeroSerie &&
                _repositorioEquipos.ExisteNumeroSerie(copia.NumeroSerie))
            {
                throw new InvalidOperationException(
                    $"Ya existe un equipo con el número de serie {copia.NumeroSerie}.");
            }

            _repositorioEquipos.Actualizar(copia);
        }
        public Equipo? BuscarPorCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                throw new ArgumentException("Debe ingresar el código del equipo.");
            }

            return _repositorioEquipos.BuscarPorCodigo(codigo);
        }
       
    }
}
