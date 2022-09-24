using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio3
{
    class Facturacion
    {
        public void calcularFactura(float valor, int cant)
        {
            float IVA = 19;
            float total = 0;
            float subtotal = 0;

            subtotal = valor * cant;
            IVA = IVA * valor * cant / 100;
            total = valor*cant + IVA;
            Console.Write("El subtotal a pagar es: " + subtotal + "\n" + "Descuento: 0% \n" + "IVA: 19% " + "\nTotal a pagar: " + total );
            
        }

        public void datosFactura(int cod, int cant, string nombre, float valor)
        {
            Console.WriteLine("Código: " + cod + "\nValor X unidad: " + valor + "\nCantidad de productos: " + cant + "\nNombre: " + nombre);
        }
    }
}
