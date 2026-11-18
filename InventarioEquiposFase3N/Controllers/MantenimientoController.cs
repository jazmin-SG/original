
using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Repositorios;
using System;
using System.ComponentModel;
using System.Globalization;

namespace InventarioEquiposFase3N.Controllers
{
    public class MantenimientoController
    {
        private readonly RepositorioMantenimientos _repositorioMantenimientos;

        public MantenimientoController(
            RepositorioMantenimientos repositorioMantenimientos)
        {
            _repositorioMantenimientos = repositorioMantenimientos;
        }

        public BindingList<Mantenimiento> ObtenerTodos()
        {
            return _repositorioMantenimientos.ObtenerTodos();
        }

        private void Validar(Mantenimiento mantenimiento)
        {
            if (mantenimiento == null)
            {
                throw new ArgumentNullException(nameof(mantenimiento));
            }

            if (string.IsNullOrWhiteSpace(mantenimiento.Equipo))
            {
                throw new ArgumentException(
                    "Debe seleccionar un equipo.");
            }

            if (!Enum.IsDefined(mantenimiento.TipoMantenimiento))
            {
                throw new ArgumentException(
                    "Debe seleccionar un tipo de mantenimiento válido.");
            }

            if (string.IsNullOrWhiteSpace(mantenimiento.Descripcion))
            {
                throw new ArgumentException(
                    "La descripción no puede estar vacía.");
            }

            if (mantenimiento.TipoMantenimiento ==
                TipoMantenimiento.Correctivo &&
                string.IsNullOrWhiteSpace(mantenimiento.TecnicoResponsable))
            {
                throw new ArgumentException(
                    "El técnico responsable es obligatorio para mantenimiento correctivo.");
            }

            if (!decimal.TryParse(
                mantenimiento.Costo,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out decimal costo) || costo < 0)
            {
                throw new ArgumentException(
                    "Debe ingresar un costo numérico válido y no negativo.");
            }
        }

        public void Agregar(Mantenimiento mantenimiento)
        {
            Validar(mantenimiento);
            _repositorioMantenimientos.Agregar(mantenimiento);
        }

        public void Actualizar(Mantenimiento mantenimiento)
        {
            Validar(mantenimiento);
            _repositorioMantenimientos.Actualizar(mantenimiento);
        }

        public void Eliminar(Mantenimiento mantenimiento)
        {
            if (mantenimiento == null)
            {
                throw new ArgumentNullException(nameof(mantenimiento));
            }

            _repositorioMantenimientos.Eliminar(mantenimiento);
        }

        public void Cargar()
        {
            _repositorioMantenimientos.Leer();
        }

        public BindingList<Mantenimiento> Buscar(string texto)
        {
            return _repositorioMantenimientos.BuscarTexto(texto);
        }

        public (decimal totalCostos, decimal promedioCostos,
            string ultimoMantenimiento, int totalRegistros)
            ObtenerResumen()
        {
            return _repositorioMantenimientos.ObtenerResumen();
        }
    }
}
