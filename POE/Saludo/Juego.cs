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
    public partial class Juego : Form
    {
        int numAlea = 0;
        public Juego()
        {
            InitializeComponent();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            numAlea = objRandom.Next(1, 11);
            MessageBox.Show("JUEGO INICIADO");
            btJugar.Enabled = true;
            btNuevo.Enabled = false;
            pbImagen.Visible = false;
            lbMensaje.Text = "";
            txNum.Clear();
        }

        private void btJugar_Click(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = Int32.Parse(txNum.Text);

                if (numAlea == num)
                {
                    lbMensaje.Text = "LO ADIVINASTE, FELICITACIONES!!";
                    pbImagen.Visible = true;
                    btJugar.Enabled = false;
                    btNuevo.Enabled = true;
                }
                else
                {
                    lbMensaje.Text = "SIGUE INTENTANDO";
                    txNum.Clear();
                    txNum.Focus();
                }
            }
            catch(Exception err) {
                MessageBox.Show("Valor no válido " + err.Message);
                lbMensaje.Text = "ERROR";
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
