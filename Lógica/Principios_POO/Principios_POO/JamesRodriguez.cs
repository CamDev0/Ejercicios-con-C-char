using System;
using System.Collections.Generic;
using System.Text;

namespace Principios_POO
{
    class JamesRodriguez : EstadisticasJugadores
    {
        public void Datos()
        {
            Console.WriteLine("\n\n JAMES RODRIGUEZ");
            JamesRodriguez objJ = new JamesRodriguez();
            objJ.nacionalidad("Colombia");
            objJ.condicion(29);
            objJ.velocidadMaxima(1.75, 59.6);
            objJ.mundial(false);
        }
    }
}
