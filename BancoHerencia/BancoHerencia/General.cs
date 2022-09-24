using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoHerencia
{
    class General
    {
        public static void imprimir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public static void imprimir(Cuenta objCuenta)
        {
            imprimir("Los datos de la cuenta son: ");
            imprimir("El número de la cuenta es " + objCuenta.getNumero());
            imprimir("Su saldo es: " + objCuenta.getSaldo() + "\n");

        }
        public static string leer(string mensaje)
        {
            string dato = "";
            imprimir(mensaje);
            return dato = Console.ReadLine();
        }
    }
}
