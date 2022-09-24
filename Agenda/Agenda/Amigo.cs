using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Amigo
    {
        private string cc = "";
        private string nombre = "";
        private int telefono = 0;
        private string correo = "";
        public int codigo = 0;
        private static int contador = 0;
        public Amigo(string cc, string nombre, int telefono, string correo)
        {
            this.cc = cc;
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
            contador = contador + 1;
            codigo = contador;
        }

        public Amigo()
        {
            cc = "";
            nombre = "";
            telefono = 0;
            correo = "";
            contador = contador + 1;
            codigo = contador;
        }

        public string getCc()
        {
            return cc;
        }

        public void setCc(string cc)
        {
            this.cc = cc;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int getTelefono()
        {
            return telefono;
        }

        public void setTelefono(int telefono)
        {
            this.telefono = telefono;
        }
        public string getCorreo()
        {
            return correo;
        }

        public void setCorreo(string correo)
        {
            this.correo = correo;
        }
    }
}
