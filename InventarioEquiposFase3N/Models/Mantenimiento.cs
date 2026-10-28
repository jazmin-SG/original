using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventarioEquiposFase3N.Models
{
    public class Mantenimiento : INotifyPropertyChanged
    {


        private string _equipo = string.Empty;
        public string Equipo
        {
            get => _equipo;
            set
            {
                if (_equipo != value)
                {
                    _equipo = value;
                    OnPropertyChanged(nameof(Equipo));
                }
            }
        }


        private TipoMantenimiento _tipoMantenimiento = TipoMantenimiento.Preventivo;
        public TipoMantenimiento TipoMantenimiento
        {
            get => _tipoMantenimiento;
            set
            {
                if (_tipoMantenimiento != value)
                {
                    _tipoMantenimiento = value;
                    OnPropertyChanged(nameof(TipoMantenimiento));
                }
            }
        }


        private DateTime _fecha = DateTime.Now;
        public DateTime Fecha
        {
            get => _fecha;
            set
            {
                if (_fecha != value)
                {
                    _fecha = value;
                    OnPropertyChanged(nameof(Fecha));
                }
            }
        }


        private string _descripcion = string.Empty;
        public string Descripcion
        {
            get => _descripcion;
            set
            {
                if (_descripcion != value)
                {
                    _descripcion = value;
                    OnPropertyChanged(nameof(Descripcion));
                }
            }
        }


        private string _tecnicoResponsable = string.Empty;
        public string TecnicoResponsable
        {
            get => _tecnicoResponsable;
            set
            {
                if (_tecnicoResponsable != value)
                {
                    _tecnicoResponsable = value;
                    OnPropertyChanged(nameof(TecnicoResponsable));
                }
            }
        }


        private string _costo = string.Empty;
        public string Costo
        {
            get => _costo;
            set
            {
                if (_costo != value)
                {
                    _costo = value;
                    OnPropertyChanged(nameof(Costo));
                }
            }
        }






        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
