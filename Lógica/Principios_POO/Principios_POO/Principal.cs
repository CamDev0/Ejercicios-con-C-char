using System;
using System.Collections.Generic;
using System.Text;

namespace Principios_POO
{
    class Principal
    {
        public static void Main (string[] args)
        {
            //Instancias de las clases (Objetos)
            LionelMessi objMessi = new LionelMessi();
            CristianoRonaldo objRonaldo = new CristianoRonaldo();
            Gavi objGavi = new Gavi();
            JamesRodriguez objJames = new JamesRodriguez();

            objMessi.Datos();
            objRonaldo.Datos();
            objGavi.Datos();
            objJames.Datos();

        }
    }
}
