using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class datosCliente
    {
        static void Main(string[] args)
        {
            //Lector
            calcularEstadisticas calc = new calcularEstadisticas();
  
            int cont = 0;
            float contSaldo = 0;
            int contSaldoNeg = 0;
            int contSaldoPos = 0;

            Console.WriteLine("Ingrese la cantidad de clientes a ingresar: ");
            cont = Int32.Parse(Console.ReadLine());

            float[] saldo = new float[cont];
            string[] genero = new string[cont];
            string[] nombre = new string[cont];
            int[] nroCuenta = new int[cont];

            for (int i = 0; i < cont; i++)
            {

                Console.WriteLine("Datos del cliente Nro: " + (i + 1));

                Console.Write("Ingrese su saldo: ");
                saldo[i] = float.Parse(Console.ReadLine());
                contSaldo += saldo[i];

                Console.Write("Ingrese su nùmero de cuenta: ");
                nroCuenta[i] = Int32.Parse(Console.ReadLine());

                Console.Write("Ingrese su género (F o M) en mayúscula por favor: ");
                genero[i] = Console.ReadLine();

                Console.Write("Ingrese su nombre: ");
                nombre[i] = Console.ReadLine();

                if (saldo[i] < 0)
                {
                    contSaldoNeg += 1;
                }
                else
                {
                    contSaldoPos += 1;
                }


            }

            calc.saldoPromedio(contSaldo, cont);
            Console.ReadLine();

            calc.saldoNegativo(contSaldoNeg);
            Console.ReadLine();

            calc.saldoPositivo(contSaldoPos);
            Console.ReadLine();

            calc.calcularSaldoMenor(saldo, nombre, cont);
            Console.ReadLine();

            calc.calcularSaldoMayor(saldo, nombre, cont, nroCuenta);
            Console.ReadLine();

            calc.promedio_Femenino_Masculino(genero, saldo);
            Console.ReadLine();
        }




    }   
}
