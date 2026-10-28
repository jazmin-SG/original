using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventarioEquiposFase3N.Models
{
    public  class Asignacion : INotifyPropertyChanged
    {


        private string _idAsignacion = Guid.NewGuid().ToString();
        public string IdAsignacion
        {
            get => _idAsignacion;
            set
            {
                if (_idAsignacion != value)
                {
                    _idAsignacion = value;
                    OnPropertyChanged(nameof(IdAsignacion));
                }
            }
        }

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


        private string _empleado = string.Empty;
        public string Empleado
        {
            get => _empleado;
            set
            {
                if (_empleado != value)
                {
                    _empleado = value;
                    OnPropertyChanged(nameof(Empleado));
                }
            }
        }


        private DateTime _fechaAsignacion = DateTime.Today;
        public DateTime FechaAsignacion
        {
            get => _fechaAsignacion;
            set
            {
                if (_fechaAsignacion != value)
                {
                    _fechaAsignacion = value;
                    OnPropertyChanged(nameof(FechaAsignacion));
                }
            }
        }


        private DateTime _fechaDevolucion = DateTime.Today;
        public DateTime FechaDevolucion
        {
            get => _fechaDevolucion;
            set
            {
                if (_fechaDevolucion != value)
                {
                    _fechaDevolucion = value;
                    OnPropertyChanged(nameof(FechaDevolucion));
                }
            }
        }


        private string _estado = string.Empty;
        public string Estado
        {
            get => _estado;
            set
            {
                if (_estado != value)
                {
                    _estado = value;
                    OnPropertyChanged(nameof(Estado));
                }
            }
        }



        private string _observacion = string.Empty;
        public string Observacion
        {
            get => _observacion;
            set
            {
                if (_observacion != value)
                {
                    _observacion = value;
                    OnPropertyChanged(nameof(Observacion));
                }
            }
        }

        public Asignacion() { }

        public Asignacion(string equipo, string empleado, DateTime fechaAsignacion, DateTime fechaDevolucion, string estado, string observacion)
        {
            _equipo = equipo;
            _empleado = empleado;
            _fechaAsignacion = fechaAsignacion;
            _fechaDevolucion = fechaDevolucion;
            _estado = estado;
            _observacion = observacion;
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
