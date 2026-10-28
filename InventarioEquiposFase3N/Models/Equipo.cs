using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventarioEquiposFase3N.Models
{
    public class Equipo : INotifyPropertyChanged
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

        private string _marca = string.Empty;
        public string Marca
        {
            get => _marca;
            set
            {
                if (_marca != value)
                {
                    _marca = value;
                    OnPropertyChanged(nameof(Marca));
                }
            }
        }


        private string _modelo = string.Empty;
        public string Modelo
        {
            get => _modelo;
            set
            {
                if (_modelo != value)
                {
                    _modelo = value;
                    OnPropertyChanged(nameof(Modelo));
                }
            }
        }


        private string _numeroSerie = string.Empty;
        public string NumeroSerie
        {
            get => _numeroSerie;
            set
            {
                if (_numeroSerie != value)
                {
                    _numeroSerie = value;
                    OnPropertyChanged(nameof(NumeroSerie));
                }
            }
        }


        private TipoEquipo _tipoEquipo = TipoEquipo.Computadora;
        public TipoEquipo TipoEquipo
        {
            get => _tipoEquipo;
            set
            {
                if (_tipoEquipo != value)
                {
                    _tipoEquipo = value;
                    OnPropertyChanged(nameof(TipoEquipo));
                }
            }
        }


        private Estado _estado = Estado.Disponible;
        public Estado Estado
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


        private DateTime _fechaCompra = DateTime.Now;
        public DateTime FechaCompra
        {
            get => _fechaCompra;
            set
            {
                if (_fechaCompra != value)
                {
                    _fechaCompra = value;
                    OnPropertyChanged(nameof(FechaCompra));
                }
            }
        }


        private int _anioGarantia = 1;
        public int AnioGarantia
        {
            get => _anioGarantia;
            set
            {
                if (_anioGarantia != value)
                {
                    _anioGarantia = value;
                    OnPropertyChanged(nameof(AnioGarantia));
                }
            }
        }
        public Equipo()
        {
        }

        public Equipo(string codigo, string marca, string modelo, string numeroSerie, TipoEquipo tipoEquipo, Estado estado, DateTime fechaCompra, int anioGarantia)
        {
            Codigo = codigo;
            Marca = marca;
            Modelo = modelo;
            NumeroSerie = numeroSerie;
            TipoEquipo = tipoEquipo;
            Estado = estado;
            FechaCompra = fechaCompra;
            AnioGarantia = anioGarantia;
        }






        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
