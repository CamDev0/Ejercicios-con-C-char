using System;
using System.Collections.Generic;
using System.Text;

namespace Principios_POO
{
    class CristianoRonaldo : EstadisticasJugadores
    {
        public void Datos()
        {
            Console.WriteLine("\n\n CRISTIANO RONALDO");
            CristianoRonaldo objC = new CristianoRonaldo();
            objC.nacionalidad("Portugal");
            objC.condicion(36);
            objC.velocidadMaxima(1.90, 65.6);
            objC.mundial(true);
        }
    }
}
