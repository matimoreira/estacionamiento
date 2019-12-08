using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    interface IParkingLot
    {
        int PrecioHora
        {
            get;
            set;
        }
        int Capacidad
        {
            get;
            set;
        }
        int CantidadEstacionados
        {
            get;
        }
        int EspaciosDisponibles
        {
            get;
        }
        double TotalFacturado
        {
            get;
        }
        void IngresoDetectado(string patente);
        void EgresoDetectado(string patente);
        IList<string> VehiculosEstacionados();
       
    }
}
