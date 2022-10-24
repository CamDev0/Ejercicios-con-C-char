using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxSalary.Text) || String.IsNullOrEmpty(textBoxTime.Text) || String.IsNullOrEmpty(textBoxDeducciones.Text))
            {
                MessageBox.Show("Debe ingresar toda la información");
                textBoxName.Clear();
                textBoxSalary.Clear();
                textBoxDeducciones.Clear();
                textBoxTime.Clear();
                textBoxName.Focus();
            }
            else
            {
                double salario = Double.Parse(textBoxSalary.Text);
                double deducciones = Double.Parse(textBoxDeducciones.Text);
                int meses = int.Parse(textBoxTime.Text);

                double salarioReal = salario - deducciones;
                string mensaje = "";
                double bonificacion = 0;

                if (meses < 36 )
                {
                    mensaje = "No tiene bonificación";
                }
                else if (meses >= 36 && meses <= 60)
                {
                    mensaje = "Su bonificacion es de: 100.000";
                    bonificacion = 100000;
                }
                else if (meses > 60)
                {
                    mensaje = "Su bonificacion es de: 200.000";
                    bonificacion = 200000;
                }
                else
                {
                    mensaje = "Error de ejecución, reintente por favor";
                    textBoxName.Clear();
                    textBoxSalary.Clear();
                    textBoxDeducciones.Clear();
                    textBoxTime.Clear();
                    textBoxName.Focus();
                }

                double salarioFinal = salarioReal + bonificacion;

                MessageBox.Show("****TOTAL A PAGARLE AL EMPLEADO**** \n\n" + "Nombre: " + textBoxName.Text +
                                "\n\nSalario: " + salarioReal + "\n\n" + "Bonificación: " + mensaje +
                                 "\n\nSalario total a pagar: " + salarioFinal);

                btnRepetir.Visible = true;
            }
        }

        private void btnRepetir_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxSalary.Clear();
            textBoxDeducciones.Clear();
            textBoxTime.Clear();
            textBoxName.Focus();
            btnRepetir.Visible = false;
        }
    }
}
