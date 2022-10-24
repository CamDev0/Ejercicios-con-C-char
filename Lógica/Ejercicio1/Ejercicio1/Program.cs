using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularRetiro lector = new CalcularRetiro();

            string nombre = "";
            string clave = "";
            string validador = "";
            float saldo = 0;
            Console.Write("----Registro---- \n\n");
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Cree una clave: ");
            clave = Console.ReadLine();

            Console.Write("Escriba de nuevo su clave: ");
            validador = Console.ReadLine();

            lector.validarClave(clave, validador, nombre);

            Console.WriteLine("Ingrese el monto a retirar. (max - 200.000): ");
            saldo = float.Parse(Console.ReadLine());

            lector.calcularCantidadBilletes(saldo);
            Console.ReadLine();
        }

    }
}

