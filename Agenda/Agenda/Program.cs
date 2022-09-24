using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        public static int LeerEntero(string mensaje)
        {
            string dato = "";
            try
            {
                dato = Metodos.leer(mensaje);
                return Int32.Parse(dato);
            }
            catch (Exception er)
            {
                Metodos.imprimir("Error" + er.Message);
                return LeerEntero(mensaje);
            }
        }
        static void Main(string[] args)
        {
            Metodos.imprimir("PROGRAMA AGENDA");
            Amigo objAmigo = new Amigo();
            //int entero = LeerEntero("Ingrese un valor entero: ");
            objAmigo.setCc("1234.4567");
            objAmigo.setNombre("Samuel");
            objAmigo.setTelefono(2131331);
            objAmigo.setCorreo("samuel@gmail.com");
            Metodos.imprimir(objAmigo.codigo + "");
            Metodos.imprimir(objAmigo);
            Amigo objAmigo1 = new Amigo("1000647529", "Andres", 2143405, "samu@gmail.com");
            Metodos.imprimir(objAmigo1.codigo + "");
            Metodos.imprimir(objAmigo1);
            Amigo objAmigo2 = new Amigo("17529", "Julian", 21405, "su@gmail.com");
            Metodos.imprimir(objAmigo2.codigo + "");
            Metodos.imprimir(objAmigo2);
            Console.ReadKey();
        }
    }
}
