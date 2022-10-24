using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoHerencia
{
    class Banco
    {

        private static Cuenta[] vecCuenta;
        static int tope = 0;
        static int tamaño;
        public static void crearClientes()
        {

            vecCuenta = new Cuenta[10];

            Cuenta objCuenta1 = new Ahorro(1, "Pablo", 1234, 500000);

            Cuenta objCuenta2 = new Corriente(2, "Gabi", 1236, 500000, 500000);

            vecCuenta[0] = objCuenta1;
            vecCuenta[1] = objCuenta2;
            Cuenta objCuenta3 = new Ahorro(3, "Juan", 5678, 50000);
            vecCuenta[2] = objCuenta3;

            Ahorro objAhorro1 = new Ahorro(4, "Juana", 1045, 300000);

            Corriente objCorriente1 = new Corriente(5, "Sol", 123, 5000000, 1000000);

            vecCuenta[3] = objAhorro1;
            vecCuenta[4] = objCorriente1;
            tope = 5;
            tamaño = 10;
            General.imprimir("Clientes ingresados al banco \n");
        }

        public static void crearClientes(int tño)
        {

            vecCuenta = new Cuenta[tño];
            tope = 0;
            tamaño = tño;

        }

        public static bool vacia()
        {
            if (tope == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool llena()
        {

            if (tope == tamaño)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int ingresarCliente(Cuenta objCuenta)
        {
            if (llena())
            {
                General.imprimir("No hay espacio en la memoria \n");
            }
            else 
            {
                vecCuenta[tope] = objCuenta;
                tope++;
            }

            return tope;
        }

        public static void imprimirClientes() {

            for (int i = 0; i < tope; i++) {

                General.imprimir("Cliente " + (i+1) + "\n");
                General.imprimir(vecCuenta[i]);
            }
        
        }

        public static Cuenta eliminarCliente()
        {
            Cuenta objc = null;
            if(vacia())
            {
                General.imprimir("No existen clientes.");
            }
            else
            {
                objc = vecCuenta[tope - 1];
                tope = tope - 1;
            }
            return objc;
        }

        public static Cuenta buscarCuenta(int numero)
        {
            Cuenta objc = null;
            if (vacia())
            {
                General.imprimir("No existen clientes.");
            }
            else
            {
                for(int i=0; i < tope; i++)
                {
                    if(vecCuenta[i].getNumero() == numero)
                    {
                        objc = vecCuenta[i];
                    }
                }
            }
            return objc;
        }

    }
}
