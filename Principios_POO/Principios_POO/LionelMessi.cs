using System;
using System.Collections.Generic;
using System.Text;

namespace Principios_POO
{
    //Herencia: Heredamos los metodos de la clase EstadisticaJugadores.
    class LionelMessi : EstadisticasJugadores
    {
        public void Datos()
        {
            Console.WriteLine("\n\n LIONEL MESSI");
            LionelMessi obj = new LionelMessi();
            obj.nacionalidad("Argentina");
            obj.condicion(34);
            obj.velocidadMaxima(1.70, 60.2);
            obj.mundial(true);
        }
    }
}
