using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventarioEquiposFase3N.Models
{
    public class Empleado : INotifyPropertyChanged  
    {

        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        private string _dui = string.Empty;
        public string Dui
        {
            get => _dui;
            set
            {
                if (_dui != value)
                {
                    _dui = value;
                    OnPropertyChanged(nameof(Dui));
                }
            }
        }

        private string _nombre = string.Empty;
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            }
        }

        private string _apellido = string.Empty;
        public string Apellido
        {
            get => _apellido;
            set
            {
                if (_apellido != value)
                {
                    _apellido = value;
                    OnPropertyChanged(nameof(Apellido));
                }
            }
        }

        private string _cargo = string.Empty;
        public string Cargo
        {
            get => _cargo;
            set
            {
                if (_cargo != value)
                {
                    _cargo = value;
                    OnPropertyChanged(nameof(Cargo));
                }
            }
        }

        private string _departamento = string.Empty;
        public string Departamento
        {
            get => _departamento;
            set
            {
                if (_departamento != value)
                {
                    _departamento = value;
                    OnPropertyChanged(nameof(Departamento));
                }
            }
        }


        private string _correo = string.Empty;
        public string Correo
        {
            get => _correo;
            set
            {
                if (_correo != value)
                {
                    _correo = value;
                    OnPropertyChanged(nameof(Correo));
                }
            }
        }

        public Empleado() { }

        public Empleado(int id, string dui, string nombre, string apellido, string cargo, string departamento, string correo)
        {
            Id = id;
            Dui = dui;
            Nombre = nombre;
            Apellido = apellido;
            Cargo = cargo;
            Departamento = departamento;
            Correo = correo;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
