using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Una  entidad  bancaria  como  servicio  adicional  a  sus  clientes  va  a  instalar  una  máquina  para cambio 
o  sencilla(similar  a  un  cajero  electrónico,  pero  con  solo  la  opción  de  retiro)  y  necesita  un  programa 
para  determinar  la cantidad mínima de billetes y de que denominación va a entregar al cliente. La máquina posee
billetes de 10.000, 5.000,  2.000  y  1.000  pesos  y  el  monto  máximo  a  retirar en  esta  máquina es  de
200.000  pesos,  el  cual  lo  debe digitar. Si el valor restante está entre 999 y 500 pesos se aproxima 
a 1.000 pesos y si es de 499 a 1 se trunca a 0. 
El usuario requiere registrarse al inicio del programa con el nombre y la clave para poder ingresar
 */


namespace Ejercicio1
{
    class CalcularRetiro
    {

        public void validarClave(string clave, string validador, string nombre)
        {
            if (clave != validador)
            {
                Console.WriteLine("Las claves no coinciden, reintente por favor.");
           
            }
            else
            {
                Console.WriteLine("Bienvenido " + nombre);

            }
        }

        public void calcularCantidadBilletes(float saldo)
        {

            int contDiez = 0;
            int contCinco = 0;
            int contDos = 0;
            int contUno = 0;

            while (saldo >= 10000)
            {
                 saldo = saldo - 10000;
                 contDiez += 1; 
            }

            while (saldo >= 5000)
            {
                saldo = saldo - 5000;
                contCinco += 1;

            }

            while (saldo >= 2000)
            {
                saldo = saldo - 2000;
                contDos += 1;

            }

            while (saldo >= 1000)
            {
                saldo = saldo - 1000;
                contUno += 1;

            }

            if (saldo >= 500 && saldo <= 999)
            {
                saldo = 0;
                contUno += 1;
            }
            else
            {
                saldo = 0;
            }

            
             Console.WriteLine("Efectivo: \n" +
                contDiez + " billetes de 10.000\n" +
                contCinco + " billetes de 5.000\n" +
                contDos + " billetes de 2.000\n" +
                contUno + " billetes de 1.000");
        }
    }
}
