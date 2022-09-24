using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class avion
    {
        public void calcularCostoAvion(int tipoHabitacion, int nroDias, float valorTransporte, float valorXMin)
        {
            float costoTotal = 0;
            float acumulador = 0;
            switch (tipoHabitacion)
            {
                case 1:
                    tipoHabitacion = 90000;
                    break;

                case 2:
                    tipoHabitacion = 55000;
                    break;

                default:
                    Console.WriteLine("Lo sentimos, tal vez escogiste un valor fuera del rango.");
                    break;
            }

            acumulador = tipoHabitacion * nroDias;
            costoTotal = acumulador + valorTransporte + valorXMin;

            Console.WriteLine("El costo total de su viaje es: " + costoTotal);
        }
    }
}
