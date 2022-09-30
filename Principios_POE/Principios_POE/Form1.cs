using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principios_POE
{
    public partial class Tittle : Form
    {
        public Tittle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.Green;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe ingresar el número.");
                textBox1.Focus();
            }

            else
            {
                int num = Int32.Parse(textBox1.Text);
                Random lector = new Random();
                int random = lector.Next(1, 10);


                if (num == random)
                {
                    pictureBox1.Visible = true;
                    ganaste.Visible = true;
                    sigue.Visible = false;
                    button2.Visible = true;
                    button1.Enabled = false;
                    return;
                }

                if (num != random)
                {
                    sigue.Visible = true;
                    textBox1.Clear();
                    textBox1.Focus();

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            button1.Enabled = true;
            button2.Visible = false;
            pictureBox1.Visible = false;
            ganaste.Visible = false;
            sigue.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
