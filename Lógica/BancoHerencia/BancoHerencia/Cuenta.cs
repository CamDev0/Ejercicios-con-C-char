using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoHerencia
{
    abstract class Cuenta
    {
        private int numero;
        private string nombre;
        private int clave;
        protected double saldo;
        public int id;
        public static int contador = 0;

        public Cuenta(int numero, string nombre, int clave, double saldo)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.clave = clave;
            this.saldo = saldo;
            contador = contador + 1;
            id = contador;
        }

        public int getNumero()
        {
            return numero;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public int getClave()
        {
            return clave;
        }

        public void setClave(int clave)
        {
            this.clave = clave;
        }

        public void consulta()
        {
            General.imprimir("Su saldo es: " + saldo);
        }

        public double getSaldo()
        {
            return saldo;
        }

        public void consignacion(double valor)
        {
            saldo = saldo + valor;
            General.imprimir("Su nuevo saldo es: " + saldo);
        }

        public abstract void retiro(double valor);
    }
}
