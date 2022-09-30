using System;

namespace Principios_POO
{
    class EstadisticasJugadores
    {

        public void nacionalidad (string nacionalidad)
        {
            Console.WriteLine("\nJugador de " + nacionalidad);
        }

        public void velocidadMaxima(double altura, double peso)
        {
            //Formulas inventadas
            Console.Write("\nLa velocidad máxima de este jugador es: " + (altura + peso) + " km");
        }

        public void condicion(int edad)
        {
            if (edad >= 15 && edad <= 25)
            {
                Console.Write("\nLa condición de este jugador es máxima");
            }

            else if (edad > 25 && edad <= 30)
            {
                Console.Write("\nLa condición de este jugador es media");
            }

            else 
            {
                Console.Write("\nLa condición de este jugador es mínima");
            }
        }

        public void mundial(Boolean dato)
        {
            if (dato)
            {
                Console.WriteLine("\nIrá al mindial con su selección.");
            }
            else
            {
                Console.WriteLine("\nNo irá al mundial.");
            }
        }
    }
}
