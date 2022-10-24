using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Una empresa de viajes que ofrece dos tipos de excursiones una en barco (duración viaje varios días)
y la otra en avión  (duración  viaje  solo horas).  en  el  programa  se deben  manejar  las  siguientes  variables:
Destino,  Nombre  y Cedula  del  cliente,  Número  de  días  de  Viaje,  Número  de  días  de  estadía,
Tipo  Camarote,  Tipo Habitación Estadía, Valor Tasa Aeroportuaria,
Valor Transporte a Muelle o Valor Transporte a Aeropuerto, Valor Minuto  de  Vuelo  y  Fecha  de  Viaje. 
Realizar  un  programa  que  permita  calcular  el  costo  para  una  excursión teniendo  en  cuenta  que 
el  Tipo  Camarote  sus  valores  son  lujo  =  70.000$,  normal  =  60.000$  y  económica  = 40.000$ por día)
y el tipo de habitación posee un costo de 90.000$ si es suite o 55.000$ normal
 */

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lectores
             barco lectorB  = new barco();
             avion lectorA = new avion();

            int tipoExcursion = 0;
            string destino = "";
            string nombre = "";
            int CC = 0;
            int nroDias = 0;
            int nroDiasEstadia = 0;
            int tipoCamarote = 0;
            int tipoHabitacion = 0;
            float valorTransporteMuelle = 0;
            float valorTransporteAero = 0;
            float valorXMinutoAero = 0;
            int diaViaje = 0;
            string mesViaje = "";


            Console.Write("Ingrese el tipo excursión: \n" +
                    "1. para Avión \n" +
                    "2. para Barco\n");
            tipoExcursion = Int32.Parse(Console.ReadLine());

            if (tipoExcursion == 1)
            {

                Console.Write("Ingrese el destino de su viaje: ");
                destino = Console.ReadLine();

                Console.Write("Ingrese su nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese su número de documento: ");
                CC = Int32.Parse(Console.ReadLine());

                Console.Write("Ingrese el número de días que estará en estadía: ");
                nroDiasEstadia = Int32.Parse(Console.ReadLine());

                Console.Write("Ingrese el tipo de habitación: \n" +
                      "1. para Suite, $ 90.000 por día.\n" +
                      "2. para Normal, $ 55.000 por día.\n");
                tipoHabitacion = Int32.Parse(Console.ReadLine());

                Console.Write("Ingrese el valor de transporte al aeropuerto: ");
                valorTransporteAero = float.Parse(Console.ReadLine());

                Console.Write("Ingrese el valor por minuto del vuelo: ");
                valorXMinutoAero = float.Parse(Console.ReadLine());

                Console.Write("Ingrese  el mes que hará el viaje: ");
                mesViaje = Console.ReadLine();

                Console.Write("Ingrese el día que hará el viaje: ");
                diaViaje = Int32.Parse(Console.ReadLine());

                lectorA.calcularCostoAvion(tipoHabitacion, nroDiasEstadia, valorTransporteAero, valorXMinutoAero);
                Console.ReadLine();

            }
            else
            {
                Console.Write("Ingrese el destino de su viaje: ");
                destino = Console.ReadLine();

                Console.Write("Ingrese su nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese su número de documento: ");
                CC = Int32.Parse(Console.ReadLine());

                Console.Write("Ingrese el número de días a viajar: ");
                nroDias = Int32.Parse(Console.ReadLine());

                Console.Write("Ingrese el número de días que estará en estadía: ");
                nroDiasEstadia = Int32.Parse(Console.ReadLine());

                Console.Write("Ingrese el tipo de camarote: \n" +
                                      "1. para camarote de Lujo, $ 70.000 por día.\n" +
                                      "2. para camarote Normal, $ 60.000 por día.\n" +
                                      "3. para camarote Económico, $ 40.000 por día.");
                tipoCamarote = Int32.Parse(Console.ReadLine());

                Console.Write("Ingrese el valor de transporte al muelle: ");
                valorTransporteMuelle = float.Parse(Console.ReadLine());

                Console.Write("Ingrese  el mes que hará el viaje: ");
                mesViaje = Console.ReadLine();

                Console.Write("Ingrese el día que hará el viaje: ");
                diaViaje = Int32.Parse(Console.ReadLine());

                lectorB.calcularCostoBarco(tipoCamarote, nroDiasEstadia, valorTransporteMuelle);
                Console.ReadLine();
            }



        }
    }
}

