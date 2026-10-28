using InventarioEquiposFase3N.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace InventarioEquiposFase3N.Repositorios
{
    public class RepositorioEquipos : RepositorioBase<Equipo>
    {
        public RepositorioEquipos() : base("equipos.json")
        {
            Leer();
        }

        public override void Actualizar(Equipo entidad)
        {
            ArgumentNullException.ThrowIfNull(entidad);

            var equipoExistente = _entidades.FirstOrDefault(e => e.Codigo == entidad.Codigo);

            if (equipoExistente != null)
            {
                equipoExistente.Marca = entidad.Marca;
                equipoExistente.Modelo = entidad.Modelo;
                equipoExistente.NumeroSerie = entidad.NumeroSerie;
                equipoExistente.TipoEquipo = entidad.TipoEquipo;
                equipoExistente.FechaCompra = entidad.FechaCompra;
                equipoExistente.AnioGarantia = entidad.AnioGarantia;
                equipoExistente.Estado = entidad.Estado;

                Guardar();
                _entidades.ResetItem(_entidades.IndexOf(equipoExistente));
            }
            else
            {
                throw new KeyNotFoundException(
                    $"No se encontró un equipo con el código {entidad.Codigo}.");
            }
        }

        public override void Agregar(Equipo entidad)
        {
            ArgumentNullException.ThrowIfNull(entidad);

            if (Existecodigo(entidad.Codigo))
            {
                throw new InvalidOperationException(
                    $"Ya existe un equipo con el código {entidad.Codigo}.");
            }

            if (ExisteNumeroSerie(entidad.NumeroSerie))
            {
                throw new InvalidOperationException(
                    "Ya existe un equipo con el mismo número de serie.");
            }

            base.Agregar(entidad);
        }

        public override void Eliminar(Equipo entidad)
        {
            base.Eliminar(entidad);
        }

        public bool ExisteNumeroSerie(string numeroSerie)
        {
            return _entidades.Any(e => e.NumeroSerie == numeroSerie);
        }

        public bool Existecodigo(string codigo)
        {
            return _entidades.Any(e => e.Codigo == codigo);
        }

        public Equipo? BuscarPorCodigo(string codigo)
        {
            return _entidades.FirstOrDefault(e => e.Codigo == codigo);
        }
    }
}