using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class barco
    {
        public void calcularCostoBarco(int tipoCamarote, int nroDias, float valorTransporte)
        {
            float costoTotal = 0;
            float acumulador = 0;
            switch (tipoCamarote)
            {
                case 1:
                    tipoCamarote = 70000;
                    break;

                case 2:
                    tipoCamarote = 60000;
                    break;

                case 3:
                    tipoCamarote = 40000;
                    break;
                default:
                    Console.WriteLine("Lo sentimos, tal vez escogiste un valor fuera del rango.");
                    break;
            }

            acumulador = tipoCamarote * nroDias;
            costoTotal = acumulador + valorTransporte;

            Console.WriteLine("El costo total de su viaje es: " + costoTotal);
        }
    }
}

