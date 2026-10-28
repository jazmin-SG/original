using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using InventarioEquiposFase3N.Models;

namespace InventarioEquiposFase3N.Repositorios
{
    public class RepositorioDepartamentos : RepositorioBase<Departamento>
    {
        public RepositorioDepartamentos(string? rutaArchivo = null)
            : base(rutaArchivo ?? Path.Combine(AppContext.BaseDirectory, "Datos", "departamentos.json"))
        {
            if (!File.Exists(RutaArchivo))
            {
                Guardar();
            }

            Leer();
        }

        public override void Agregar(Departamento entidad)
        {
            ArgumentNullException.ThrowIfNull(entidad);

            entidad.Validar();

            if (BuscarPorCodigo(entidad.Codigo) != null)
            {
                throw new InvalidOperationException("Ya existe un departamento con ese código.");
            }

            base.Agregar(entidad);
        }

        public override void Actualizar(Departamento entidad)
        {
            ArgumentNullException.ThrowIfNull(entidad);

            entidad.Validar();

            Departamento original = BuscarPorCodigo(entidad.Codigo)
                ?? throw new KeyNotFoundException("No se encontró el departamento.");

            if (ReferenceEquals(original, entidad))
            {
                Guardar();
                _entidades.ResetItem(_entidades.IndexOf(original));
                return;
            }

            string nombreAnterior = original.Nombre;
            string ubicacionAnterior = original.Ubicacion;
            string encargadoAnterior = original.Encargado;

            original.Nombre = entidad.Nombre;
            original.Ubicacion = entidad.Ubicacion;
            original.Encargado = entidad.Encargado;

            try
            {
                Guardar();
                _entidades.ResetItem(_entidades.IndexOf(original));
            }
            catch
            {
                original.Nombre = nombreAnterior;
                original.Ubicacion = ubicacionAnterior;
                original.Encargado = encargadoAnterior;
                throw;
            }
        }

        public override void Eliminar(Departamento entidad)
        {
            ArgumentNullException.ThrowIfNull(entidad);

            Departamento original = BuscarPorCodigo(entidad.Codigo)
                ?? throw new KeyNotFoundException("No se encontró el departamento.");

            base.Eliminar(original);
        }

        public Departamento? BuscarPorCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                return null;
            }

            return _entidades.FirstOrDefault(d =>
                string.Equals(
                    d.Codigo.Trim(),
                    codigo.Trim(),
                    StringComparison.OrdinalIgnoreCase));
        }

        public BindingList<Departamento> BuscarTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return ObtenerTodos();
            }

            List<Departamento> encontrados = _entidades.Where(d =>
                d.Codigo.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                d.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                d.Ubicacion.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                d.Encargado.Contains(texto, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            return new BindingList<Departamento>(encontrados);
        }

        protected override void ValidarDatos(List<Departamento> datos)
        {
            base.ValidarDatos(datos);

            HashSet<string> codigos =
                new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (Departamento departamento in datos)
            {
                try
                {
                    departamento.Validar();
                }
                catch (ArgumentException ex)
                {
                    throw new InvalidDataException(
                        "Departamento inválido en JSON.", ex);
                }

                if (!codigos.Add(departamento.Codigo.Trim()))
                {
                    throw new InvalidDataException(
                        "Hay códigos de departamento duplicados.");
                }
            }
        }
    }
}
