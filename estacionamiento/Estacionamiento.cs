using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Entidades
{

public class Estacionamiento : IParkingLot
    {
        //Campos
        private int _precioHora;
        private int _capacidad;
        private Double _totalFacturado;
        private IList<string> _vehiculosEstacionados;

        private struct vehiculo
        {
            public string patente;
            public DateTime fecha;
        }
        private IList<vehiculo> _Vehiculos = new List<vehiculo>();

        //Constructores
        public Estacionamiento() 
        {
            _precioHora = 0;
            _capacidad = 0;
            _vehiculosEstacionados = new List<string>();
            _Vehiculos = new List<vehiculo>();
        }

        public Estacionamiento(int p_capacidad, int p_precioHora, int p_tiempoMinimo)
        {
            _capacidad = p_capacidad;
            _precioHora = p_precioHora;
            _vehiculosEstacionados = new List<string>();
            _Vehiculos = new List<vehiculo>();
        }



        //Propiedades
        public int PrecioHora
        {
            get
            {
                return _precioHora;
            }
            set
            {
                _precioHora = value;
            }
        }
        
        public int Capacidad {
            get
            {
                return _capacidad;
            }
            set
            {
                _capacidad = value;
            }
        }
       
        public int CantidadEstacionados { 
            get
            {
                return _Vehiculos.Count;
            }
        }
       
        public int EspaciosDisponibles
        {
            get
            {
                return _capacidad - _Vehiculos.Count;
            }
        }
        
        public double TotalFacturado { 
            get
            {
                return _totalFacturado;
            }
        }


        //Metodos
        public void IngresoDetectado(string patente)
        {
            _vehiculosEstacionados.Add(patente);
            vehiculo vehiculo;
            vehiculo.patente = patente;
            vehiculo.fecha = DateTime.Now;
            _Vehiculos.Add(vehiculo);
        }

        public void EgresoDetectado(string patente)
        {
            int indice = _vehiculosEstacionados.IndexOf(patente);
            int diferenciaFechas = ((TimeSpan)(DateTime.Now - _Vehiculos[indice].fecha)).Hours;
            _Vehiculos.RemoveAt(indice);
            if (diferenciaFechas == 0)
            {
                ++diferenciaFechas;
            }
            _totalFacturado += diferenciaFechas *  _precioHora;
        }

        public IList<string> VehiculosEstacionados()
        {
            _vehiculosEstacionados.Clear();
            IEnumerable<vehiculo> sorted_Vehiculos = _Vehiculos.OrderBy(v => v.fecha);
            
            //IList<vehiculo> sorted_Vehiculos = sortedEnum.ToList();
            foreach (var vehiculo in sorted_Vehiculos.ToList())
            {
                _vehiculosEstacionados.Add(vehiculo.patente);
            }
            return _vehiculosEstacionados;
        }

        public DateTime getFechaHora(string p_patente)
        {
            int indice = _vehiculosEstacionados.IndexOf(p_patente);
            return _Vehiculos[indice].fecha;
        }

    }
}
