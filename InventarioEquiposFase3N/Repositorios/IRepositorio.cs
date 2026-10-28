using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventarioEquiposFase3N.Repositorios
{
    public interface IRepositorio<T>
    {
        void Agregar(T entidad);
        void Eliminar(T entidad);
        void Actualizar(T entidad);
        BindingList<T> ObtenerTodos();
    }
}
