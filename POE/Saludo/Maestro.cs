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

        private void saludarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hola objh = new Hola();
            objh.MdiParent = this;
            objh.Show();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja objc = new Caja();
            objc.MdiParent = this;
            objc.Show();
        }
    }
}
