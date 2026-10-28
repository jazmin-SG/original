using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventarioEquiposFase3N.Repositorios
{
    public class RepositorioBase<T> : IRepositorio<T> where T : class
    {
        protected BindingList<T> _entidades { get; } = new BindingList<T>();

        public string RutaArchivo { get; }

        private readonly JsonSerializerOptions _opciones = new()
        {
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };

        protected RepositorioBase(string rutaArchivo)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(rutaArchivo);
            RutaArchivo = Path.GetFullPath(rutaArchivo);
        }
        public virtual void Actualizar(T entidad)
        {

            ArgumentNullException.ThrowIfNull(entidad);
            if (!_entidades.Contains(entidad))
                throw new InvalidOperationException("La entidad no existe en el repositorio.");

            Guardar();
            _entidades.ResetItem(_entidades.IndexOf(entidad));

        }

        public virtual void Agregar(T entidad)
        {
            ArgumentNullException.ThrowIfNull(entidad);
            if (_entidades.Contains(entidad))
            {
                throw new InvalidOperationException("La entidad ya existe en el repositorio.");
            }

            var datos = _entidades.ToList();
            datos.Add(entidad);
            GuardarLista(datos);

            _entidades.Add(entidad);
        }

        public virtual void Eliminar(T entidad)
        {
            ArgumentNullException.ThrowIfNull(entidad);
            if (!_entidades.Contains(entidad))
                throw new InvalidOperationException("La entidad no existe en el repositorio.");

            var datos = _entidades.ToList();
            datos.Remove(entidad);
            GuardarLista(datos);
            _entidades.Remove(entidad);
        }

        public BindingList<T> ObtenerTodos()
        {
            return _entidades;
        }

        public void Guardar()
        {
            GuardarLista(_entidades.ToList());

        }



        public void Leer()
        {
            if (!File.Exists(RutaArchivo))
                return;

            List<T> datos;
            try
            {
                string json = File.ReadAllText(RutaArchivo);
                datos = JsonSerializer.Deserialize<List<T>>(json, _opciones)
                    ?? throw new JsonException("Se esperaba un arreglo JSON, no null.");
            }
            catch (JsonException ex)
            {
                throw new InvalidDataException(
                    $"El archivo '{RutaArchivo}' contiene JSON inválido. No se ha modificado.", ex);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                throw new IOException($"No se pudo leer el archivo '{RutaArchivo}'.", ex);
            }

            ValidarDatos(datos);
            _entidades.RaiseListChangedEvents = false;
            try
            {
                _entidades.Clear();
                foreach (T entidad in datos)
                    _entidades.Add(entidad);
            }
            finally
            {
                _entidades.RaiseListChangedEvents = true;
                _entidades.ResetBindings();
            }
        }




        protected virtual void ValidarDatos(List<T> datos)
        {
            if (datos.Any(entidad => entidad is null))
                throw new InvalidDataException($"El archivo '{RutaArchivo}' contiene elementos null.");
        }


        private void GuardarLista(List<T> datos)
        {
            ValidarDatos(datos);
            string json = JsonSerializer.Serialize(datos, _opciones);
            string rutaTemporal = RutaArchivo + ".tmp";

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(RutaArchivo)!);
                File.WriteAllText(rutaTemporal, json);
                File.Move(rutaTemporal, RutaArchivo, overwrite: true);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                throw new IOException(
                    $"No se pudo guardar '{RutaArchivo}'. Revise permisos y espacio disponible.", ex);
            }
        }
    }
}
