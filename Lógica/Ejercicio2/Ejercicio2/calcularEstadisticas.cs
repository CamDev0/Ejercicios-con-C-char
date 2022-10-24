using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Una entidad bancaria requiere analizar en comportamiento de sus ahorradores, por cada cliente se posee:
el saldo, el número de la cuenta, el género y nombre.  Se solita hallarlassiguientes estadísticas:
•Saldo promedio.
•Cuántos tienen saldo rojo o negativo.
•Cuántos tienen saldo positivo o mayor o igual a cero.
•Cuál es el menor saldo y su nombre.
•Cuál es el mayor saldo, el nombre y número de cuenta
•Promedio de saldos de los hombres y de las mujeres.
 */

namespace Ejercicio2
{
    class calcularEstadisticas
    {

        public void saldoPromedio(float saldo, int cont)
        {
            float contSaldo = 0;
    
            contSaldo = saldo / cont;

             Console.WriteLine("El saldo promedio de los ahorradores es: " + contSaldo);
        }

        public void saldoNegativo(int contSaldoN)
        {
            Console.WriteLine("Hay " + contSaldoN + " personas con saldo negativo");
        }

        public void saldoPositivo(int contSaldoP)
        {
            Console.WriteLine("Hay " + contSaldoP + " personas con saldo positivo");
        }

        public void calcularSaldoMenor(float[]saldo, string[]nombre, int cont)
        {
            float saldoMenor = saldo[0];
            string nombreMenor = nombre[0];

            for (int i = 1; i < cont; i++)
            {
               if (saldoMenor > saldo[i])
                {
                    saldoMenor = saldo[i];
                    nombreMenor = nombre[i];
                }
            }

            Console.WriteLine("- " + nombreMenor + " es el de menor saldo, con: " + saldoMenor);
        }


        public void calcularSaldoMayor(float[] saldoMa, string[]nombreMa, int cont, int[]nroCuenta)
        {
            float saldoMayor = saldoMa[0];
            string nombreMayor = nombreMa[0];
            int nroC = nroCuenta[0]; 

            for (int i = 1; i < cont; i++)
            {
                if (saldoMayor < saldoMa[i])
                {
                    saldoMayor = saldoMa[i];
                    nombreMayor = nombreMa[i];
                    nroC = nroCuenta[i];
                }
             
            }
            Console.WriteLine("- " + nombreMayor + " es el de mayor saldo, con: " + saldoMayor + " y número de cuenta: " + nroC);
        }


        public void promedio_Femenino_Masculino(string[]genero, float[]saldo)
        {
            int masculino = 0;
            int femenino = 0;
            int contM = 0;
            int contF = 0;
            float contSaldoMasculino = 0;
            float contSaldoFemenino = 0;

            for (int i = 0; i < genero.Length; i++)
            {
                if(genero[i] == "M")
                {
                    masculino += 1;
                    contSaldoMasculino += saldo[i];
                    contM += 1;
                }
                else if(genero[i] == "F") {

                    femenino += 1;
                    contSaldoFemenino += saldo[i];
                    contF += 1;
                }
                else
                {
                    Console.WriteLine("No se pudo encontrar su genero, por favor, ingrese (M ó F) en mayuscula.");
                    break;
                }
            }

            Console.WriteLine("El saldo promedio masculino es: " + contSaldoMasculino / contM );
            Console.WriteLine("El saldo promedio femenino es: " + contSaldoFemenino / contF);
        }
    }
}
