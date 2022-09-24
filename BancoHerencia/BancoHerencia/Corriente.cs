using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoHerencia
{
    class Corriente : Cuenta
    {
        private double giro;
        public Corriente(int numero, string nombre, int clave, double saldo, double giro) : base(numero, nombre, clave, saldo)
        {
            this.giro = giro;
        }

        public double getGiro()
        {
            return giro;
        }

        public void  setGiro(double giro)
        {
            this.giro = giro;
        }

        public override void retiro(double valor) { 
        
            if (valor >= saldo + giro)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                saldo = saldo - valor;
                Console.WriteLine("Transacción exitosa, su saldo es " + saldo);
            }
        }
    }
}
