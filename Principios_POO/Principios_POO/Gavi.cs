using System;
using System.Collections.Generic;
using System.Text;

namespace Principios_POO
{
    class Gavi : EstadisticasJugadores
    {
        public void Datos()
        {
            Console.WriteLine("\n\n PABLO GAVIRIA");
            Gavi objG = new Gavi();
            objG.nacionalidad("España");
            objG.condicion(17);
            objG.velocidadMaxima(1.70, 55.6);
            objG.mundial(true);
        }
    }
}
