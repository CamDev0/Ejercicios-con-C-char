using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio3
{
    class Productos
    {
        int codigo;
        string nombre;
        int cantidad;
        float valor;

        public Productos(int codigo, string nombre, int cantidad, float valor)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.valor = valor;
        }

        public int getCod()
        {
            return codigo;
        }

        public void setCod(int codigo)
        {
            this.codigo = codigo;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
        public float getValor()
        {
            return valor;
        }

        public void setValor(float valor)
        {
            this.valor = valor;
        }
    }
}
