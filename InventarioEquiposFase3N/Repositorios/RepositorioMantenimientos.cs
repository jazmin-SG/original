using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using InventarioEquiposFase3N.Models;

namespace InventarioEquiposFase3N.Repositorios
{
    public class RepositorioMantenimientos : RepositorioBase<Mantenimiento>
    {
        public RepositorioMantenimientos(string rutaArchivo = "mantenimientos.json") : base(rutaArchivo)
        {
        }

       
        public (decimal totalCostos, decimal promedioCostos, string ultimoMantenimiento, int totalRegistros) ObtenerResumen()
        {
            if (_entidades == null || !_entidades.Any())
            {
                return (0m, 0m, "Sin registros", 0);
            }

           
            decimal total = _entidades.Sum(m => Convert.ToDecimal(m.Costo));
            decimal promedio = _entidades.Average(m => Convert.ToDecimal(m.Costo));
            int cantidad = _entidades.Count;
            string ultimo = _entidades.Count > 0 ? _entidades[_entidades.Count - 1].Fecha.ToString() : "--/--/----";

            return (total, promedio, ultimo, cantidad);
        }

    
        public BindingList<Mantenimiento> BuscarTexto(string busqueda)
        {
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                return ObtenerTodos();
            }

            var textoMinuscula = busqueda.ToLower();
            var filtrar = _entidades.Where(m =>
                m.Equipo.ToLower().Contains(textoMinuscula) ||
                m.TecnicoResponsable.ToLower().Contains(textoMinuscula) ||
                m.Descripcion.ToLower().Contains(textoMinuscula)).ToList();

            return new BindingList<Mantenimiento>(filtrar);
        }
    }
}