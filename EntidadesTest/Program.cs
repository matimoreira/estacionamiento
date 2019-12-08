using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace EntidadesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento estacionamiento = new Estacionamiento(100, 200, 15);
            Console.WriteLine("Capacidad: " + estacionamiento.Capacidad.ToString());
            Console.WriteLine("Lugares Disponibles: " + estacionamiento.EspaciosDisponibles.ToString());
            Console.WriteLine("Cantidad de vehiculos estacionados: " + estacionamiento.CantidadEstacionados.ToString());
            Console.WriteLine("Total Facturardo: " + estacionamiento.TotalFacturado.ToString());
            estacionamiento.IngresoDetectado("AAA 001");
            estacionamiento.IngresoDetectado("AAA 002");
            estacionamiento.IngresoDetectado("AAA 003"); 

            foreach (var patente in estacionamiento.VehiculosEstacionados())
            {
                Console.WriteLine(patente);
            }
            Console.WriteLine("Capacidad: " + estacionamiento.Capacidad.ToString());
            Console.WriteLine("Lugares Disponibles: " + estacionamiento.EspaciosDisponibles.ToString());
            Console.WriteLine("Cantidad de vehiculos estacionados: " + estacionamiento.CantidadEstacionados.ToString());
            Console.WriteLine("Total Facturardo: " + estacionamiento.TotalFacturado.ToString());
            estacionamiento.EgresoDetectado("AAA 001");
            foreach (var patente in estacionamiento.VehiculosEstacionados())
            {
                Console.WriteLine(patente);
            }
            Console.WriteLine("Capacidad: " + estacionamiento.Capacidad.ToString());
            Console.WriteLine("Lugares Disponibles: " + estacionamiento.EspaciosDisponibles.ToString());
            Console.WriteLine("Cantidad de vehiculos estacionados: " + estacionamiento.CantidadEstacionados.ToString());
            Console.WriteLine("Total Facturardo: " + estacionamiento.TotalFacturado.ToString());
            Console.ReadKey();
        }
    }
}
