using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventarioEquiposFase3N.Models
{
    public class Departamento : INotifyPropertyChanged
    {
        private string _codigo = string.Empty;
        public string Codigo
        {
            get => _codigo;
            set
            {
                if (_codigo != value)
                {
                    _codigo = value;
                    OnPropertyChanged(nameof(Codigo));
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

        private string _ubicacion = string.Empty;
        public string Ubicacion
        {
            get => _ubicacion;
            set
            {
                if (_ubicacion != value)
                {
                    _ubicacion = value;
                    OnPropertyChanged(nameof(Ubicacion));
                }
            }
        }

        private string _encargado = string.Empty;
        public string Encargado
        {
            get => _encargado;
            set
            {
                if (_encargado != value)
                {
                    _encargado = value;
                    OnPropertyChanged(nameof(Encargado));
                }
            }
        }

        public Departamento()
        {
        }

        public Departamento(string codigo, string nombre, string ubicacion, string encargado)
        {
            Codigo = codigo;
            Nombre = nombre;
            Ubicacion = ubicacion;
            Encargado = encargado;
        }

        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Codigo))
            {
                throw new ArgumentException("El código del departamento es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(Nombre))
            {
                throw new ArgumentException("El nombre del departamento es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(Ubicacion))
            {
                throw new ArgumentException("La ubicación del departamento es obligatoria.");
            }

            if (string.IsNullOrWhiteSpace(Encargado))
            {
                throw new ArgumentException("El encargado del departamento es obligatorio.");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}