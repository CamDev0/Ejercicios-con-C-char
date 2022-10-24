using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(20, 0);
            int opcion = 0, opcion1 = 0;
            int numeroCuenta = 0;
            string nombreCuenta = "";
            int claveCuenta = 0;
            double saldoCuenta = 0;

            //Cuenta[] vecCuenta = new Cuenta[10];

            General.imprimir("--BIENVENIDO AL PROGRAMA BANCO-- \n");
            do
            {
                opcion = Int32.Parse(General.leer("Menú principal: \n" +
                    "1. Manejo cliente \n" +
                    "2. Transacciones \n" +
                    "0. Salir"));

                switch (opcion)
                {

                    case 1:
                        do
                        {
                            opcion1 = Int32.Parse(General.leer("Menu cliente: \n" +
                                "1. Crear clientes por defecto \n" +
                                "2. Crear clientes vacio \n" +
                                "3. Ingresar clientes \n" +
                                "4. Eliminar cliente \n" +
                                "5. Imprimir clientes \n" +
                                "0. Regresar"));
                            switch (opcion1)
                            {
                                case 1:
                                    Banco.crearClientes();
                                    break;
                                case 2:
                                    int tamaño = Int32.Parse(General.leer("Digite la cantidad de clientes"));
                                    Banco.crearClientes(tamaño);
                                    break;
                                case 3:
                                    Cuenta obj;
                                    int op = Int32.Parse(General.leer("1. Cuenta ahorro \n 2. Cuenta corriente"));
                                    numeroCuenta = Int32.Parse(General.leer("Digite el número de la cuenta: "));
                                    nombreCuenta = General.leer("Digite el nombre del titular: ");
                                    claveCuenta = Int32.Parse(General.leer("Digite la clave de la cuenta: "));
                                    saldoCuenta = Double.Parse(General.leer("Digite el saldo de la cuenta: "));
                                    if (op == 1)
                                    {
                                        obj = new Ahorro(numeroCuenta, nombreCuenta, claveCuenta, saldoCuenta);
                                    }
                                    else {
                                        double sobregiro = Double.Parse(General.leer("Digite el sobregiro de la cuenta: "));
                                        obj = new Corriente(numeroCuenta, nombreCuenta, claveCuenta, saldoCuenta,sobregiro);
                                    }
                                    Banco.ingresarCliente(obj);
                                    break;
                                case 4:
                                    Cuenta objc = Banco.eliminarCliente();
                                    if(objc == null)
                                    {
                                        General.imprimir("No se pudo eliminar el último cliente");
                                    }
                                    else
                                    {
                                        General.imprimir("Se eliminó el último cliente, que es: ");
                                        General.imprimir(objc);
                                    }
                                    break;
                                case 5:
                                    Banco.imprimirClientes();
                                    break;
                                case 0:
                                    break;
                                default:
                                    General.imprimir("");
                                    break;
                            }
                        } while (opcion1 != 0);
                        break;
                    case 2:
                        opcion1 = Int32.Parse(General.leer("Menú de operaciones.\n" +
                            "1. Consultar saldo.\n" +
                            "2. Consignación.\n" +
                            "3. Retiro.\n" +
                            "0. Retornar."));
                        switch (opcion1)
                        {
                            case 1:
                                int num = Int32.Parse(General.leer("Digite su número de cuenta: "));
                                Cuenta obj = Banco.buscarCuenta(num);
                                if(obj == null)
                                {
                                    General.imprimir("El cliente no existe.");
                                }
                                else
                                {
                                    int clave = Int32.Parse(General.leer("Digite la clave: "));
                                    if(obj.getClave() == clave)
                                    {
                                        General.imprimir(obj);
                                    }
                                }
                                break;
                            case 2:
                                int num1 = Int32.Parse(General.leer("Digite su número de cuenta: "));
                                Cuenta objc = Banco.buscarCuenta(num1);
                                if (objc == null)
                                {
                                    General.imprimir("El cliente no existe.");
                                }
                                else
                                {
                                    int clave = Int32.Parse(General.leer("Digite la clave: "));
                                    if (objc.getClave() == clave)
                                    {
                                        double cant = Double.Parse(General.leer("Digite la cantidad a retirar: "));
                                        objc.retiro(cant);
                                        General.imprimir(objc);
                                    }
                                }
                                break;
                        }
                        break;
                    case 0:
                        General.imprimir("Fin del programa");
                        break;
                    default:
                        General.imprimir("Ingrese una opción correcta");
                        break;
                }
            } while (opcion != 0);
            Console.ReadKey();
        }
    }
}
