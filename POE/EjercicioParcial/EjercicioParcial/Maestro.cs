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
    public partial class Maestro : Form
    {
        public Maestro()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objSalario = new Form1();
            objSalario.MdiParent= this;
            objSalario.Show();
        }
    }
}
