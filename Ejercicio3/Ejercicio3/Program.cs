using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Realizar un programa para la facturación de un almacén. Los artículos deben manejasen con un vector de objetos 
con los atributos código, nombre, valor y cantidad existente. El usuario solo debe ingresar el código del articulo
y la  cantidad,  al  finalizar  el  proceso  de  compra  se  debe  imprimir  la  factura  con  los  datos  por artículo 
de:  código, nombre, valor, cantidad, IVA y si posee descuento, el subtotal y el total apagar por la factura

(No completado corretamente.)
 */
namespace Ejercicio3
{
    class Program
    {

        static void Main(string[] args)
        {
            Facturacion lectorFac = new Facturacion();


            int codigo = 0;
            string nombre = "";
            int cantidad = 0;
            float valor = 0;

            Productos lectorObj = new Productos(codigo,nombre,cantidad,valor);

            lectorObj.setCod(111111);
            lectorObj.setValor(20000);
            lectorObj.setCantidad(20);
            lectorObj.setNombre("Audifonos");

            codigo = lectorObj.getCod();
            valor = lectorObj.getValor();
            cantidad = lectorObj.getCantidad();
            nombre = lectorObj.getNombre();

            Console.WriteLine("****** FACTURA DE COMPRA *******\n\n");

            lectorFac.datosFactura(codigo, cantidad, nombre, valor);
            Console.ReadLine();

            lectorFac.calcularFactura(valor, cantidad);
            Console.ReadLine();

        }
    }
}
