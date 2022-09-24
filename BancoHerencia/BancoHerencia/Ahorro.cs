using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoHerencia
{
    class Ahorro : Cuenta
    {
        public Ahorro(int numero, string nombre, int clave, double saldo) :
            base(numero, nombre, clave, saldo)
        {
        }

        public override void retiro(double valor) {
            if (valor >= saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else {
                saldo = saldo - valor;
                Console.WriteLine("Transacción exitosa, su nuevo saldo es " + saldo);
            }


        }
    }
}
