using InventarioEquiposFase3N.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventarioEquiposFase3N.Repositorios
{
    public class RepositorioEmpleados : RepositorioBase<Empleado>
    {
        public RepositorioEmpleados() : base("empleados.json") 
        {
            Leer();
        }
        public override void Agregar(Empleado entidad)
        {
            if(ExisteDui(entidad.Dui))
            {
                throw new ArgumentException("Ya existe un empleado con el mismo DUI");
            }

            entidad.Id = _entidades.Count > 0 ? _entidades.Max(e => e.Id) + 1 : 1;
            base.Agregar(entidad);
        }
        public override void Actualizar(Empleado entidad) 
        {
            var empleadoOriginal = _entidades.FirstOrDefault(e => e.Id == entidad.Id);
            if (empleadoOriginal != null)
            {
                empleadoOriginal.Dui = entidad.Dui;
                empleadoOriginal.Nombre = entidad.Nombre;
                empleadoOriginal.Apellido = entidad.Apellido;
                empleadoOriginal.Cargo = entidad.Cargo;
                empleadoOriginal.Departamento = entidad.Departamento;
                empleadoOriginal.Correo = entidad.Correo;

                Guardar();
                _entidades.ResetItem(_entidades.IndexOf(empleadoOriginal));
            }
            else 
            {
                throw new KeyNotFoundException("No se ha encontrado el empleado");
            }
        }

        public BindingList<Empleado> BuscarTexto(string busqueda) 
        {
            if (string.IsNullOrWhiteSpace(busqueda)) 
            {
                return _entidades;
            }

            var textoMinuscula = busqueda.ToLower();
            var filtrar = _entidades.Where(e =>
            e.Nombre.ToLower().Contains(textoMinuscula) ||
            e.Apellido.ToLower().Contains(textoMinuscula) ||
            e.Dui.ToLower().Contains(textoMinuscula)).ToList();

            return new BindingList<Empleado>(filtrar);
        }

        public bool ExisteDui(string dui, Empleado? excluir = null) 
        {
            return _entidades.Any(e => e.Dui == dui && (excluir == null || e.Id != excluir.Id));
        }
    }
}
