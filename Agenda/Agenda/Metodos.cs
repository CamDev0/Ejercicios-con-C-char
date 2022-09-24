using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Metodos
    {
        public static void imprimir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public static string leer(string mensaje)
        {
            imprimir(mensaje);
            return Console.ReadLine();
        }
        public static void imprimir(Amigo obj)
        {
            imprimir("CC: " + obj.getCc());
            imprimir("Nombre: " + obj.getNombre());
            imprimir("Telefono: " + obj.getTelefono());
            imprimir("Correo: " + obj.getCorreo());
        }
    }
}
