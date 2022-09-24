using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saludo
{
    public partial class Hola : Form
    {
        public Hola()
        {
            InitializeComponent();
        }

        private void btSaludar_Click(object sender, EventArgs e)
        {
            string nombre = "";
            nombre = txNom.Text; //capturar lo de la caja de texto
            lbMensaje.Text = "Bienvenido a la POE " + nombre;
            pbImagen.Visible = true;
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            lbMensaje.Text = "";
            txNom.Clear();                         
            pbImagen.Visible = false;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
