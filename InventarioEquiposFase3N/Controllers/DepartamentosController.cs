using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InventarioEquiposFase3N.Controllers
{
    public class DepartamentosController
    {
        private readonly RepositorioDepartamentos _repositorioDepartamentos;

        public DepartamentosController(RepositorioDepartamentos repositorioDepartamentos)
        {
            _repositorioDepartamentos = repositorioDepartamentos;
        }

        public BindingList<Departamento> ObtenerTodos()
        {
            return _repositorioDepartamentos.ObtenerTodos();
        }

        public void Agregar(Departamento departamento)
        {
            if (departamento == null)
            {
                throw new ArgumentNullException(nameof(departamento));
            }

            if (string.IsNullOrWhiteSpace(departamento.Codigo))
            {
                throw new ArgumentException("El código del departamento es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(departamento.Nombre))
            {
                throw new ArgumentException("El nombre del departamento es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(departamento.Ubicacion))
            {
                throw new ArgumentException("La ubicación del departamento es obligatoria.");
            }

            if (string.IsNullOrWhiteSpace(departamento.Encargado))
            {
                throw new ArgumentException("El encargado del departamento es obligatorio.");
            }

            if (_repositorioDepartamentos.BuscarPorCodigo(departamento.Codigo) != null)
            {
                throw new InvalidOperationException("Ya existe un departamento con ese código.");
            }

            _repositorioDepartamentos.Agregar(departamento);
        }

        public void Actualizar(Departamento original, Departamento copia)
        {
            if (original == null)
            {
                throw new ArgumentNullException(nameof(original));
            }

            if (copia == null)
            {
                throw new ArgumentNullException(nameof(copia));
            }

            Departamento? departamentoExistente =
                _repositorioDepartamentos.BuscarPorCodigo(original.Codigo);

            if (departamentoExistente == null)
            {
                throw new KeyNotFoundException("No se encontró el departamento.");
            }

            if (original.Codigo != copia.Codigo)
            {
                throw new InvalidOperationException("No se puede modificar el código del departamento.");
            }

            if (string.IsNullOrWhiteSpace(copia.Nombre))
            {
                throw new ArgumentException("El nombre del departamento es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(copia.Ubicacion))
            {
                throw new ArgumentException("La ubicación del departamento es obligatoria.");
            }

            if (string.IsNullOrWhiteSpace(copia.Encargado))
            {
                throw new ArgumentException("El encargado del departamento es obligatorio.");
            }

            _repositorioDepartamentos.Actualizar(copia);
        }

        public void Eliminar(Departamento departamento)
        {
            if (departamento == null)
            {
                return;
            }

            Departamento? departamentoExistente =
                _repositorioDepartamentos.BuscarPorCodigo(departamento.Codigo);

            if (departamentoExistente == null)
            {
                throw new KeyNotFoundException("No se encontró el departamento.");
            }

            _repositorioDepartamentos.Eliminar(departamentoExistente);
        }

        public Departamento? BuscarPorCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                return null;
            }

            return _repositorioDepartamentos.BuscarPorCodigo(codigo);
        }

        public BindingList<Departamento> Buscar(string texto)
        {
            return _repositorioDepartamentos.BuscarTexto(texto);
        }
    }
}