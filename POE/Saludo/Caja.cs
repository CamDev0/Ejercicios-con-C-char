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
    public partial class Caja : Form
    {
        double totalTotal = 0, totalIva = 0, totalDescuento = 0, subtotal = 0, Iva = 0, descuento = 0;
        double totalCaja = 0, ivaCaja = 0, descuentoCaja = 0;

        private void btPagar_Click(object sender, EventArgs e)
        {
            double pago = Double.Parse(txPago.Text);

            if (pago >= totalTotal)
            {
                double devuelta = pago - totalTotal;
                MessageBox.Show("Su compra fue exitosa\nSu devuelta es de: " + devuelta);
                valorEfecivo.Visible = false;
                txPago.Visible = false;
                btPagar.Visible = false;
                gbFactura.Visible = false;
                gbDatos.Enabled = true;
                txCliente.Clear();
                txPago.Clear();
                totalCaja = totalCaja + totalTotal;
                ivaCaja = ivaCaja + totalIva;
                descuentoCaja = descuentoCaja + totalDescuento;
            }
            else
            {
                MessageBox.Show("Cantidad insuficiente, ingrese una nueva cantidad.");
            } 
        }

        private void btCerrarS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El total realizado fue " + totalCaja + "\nEl total de descuentos fue: " + descuentoCaja + "\ny el total del IVA recaudado fue: " + ivaCaja);
            totalCaja = 0;
            descuentoCaja = 0;
            ivaCaja = 0;
            gbLogueo.Enabled = true;
            gbCaja.Visible = false;
            txNombre.Clear();
            txClave.Clear();
            txNombre.Focus();
        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txPago_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txNombre.Clear();
            txClave.Clear();
            txNombre.Focus();
        }

        private void btFin_Click(object sender, EventArgs e)
        {
            txSalida.Text = txSalida.Text + "\r\n\r\nEl total a pagar es: " + totalTotal + "\r\nSu ahorro fue de: " + totalDescuento + "\r\n" + "Total IVA: " + totalIva;

            valorEfecivo.Visible = true;
            txPago.Visible = true;
            btPagar.Visible = true;
        }

        private void cbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbArticulo.Text)
            {
                case "Pantalón":
                    txValor.Text = "100000";
                    break;
                case "Camisa":
                    txValor.Text = "80000";
                    break;
                case "Falda":
                    txValor.Text = "45000";
                    break;
                case "Medias":
                    txValor.Text = "5000";
                    break;
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            double valor = Double.Parse(txValor.Text);
            int cantidad = Int32.Parse(numCantidad.Value.ToString());

            subtotal = valor * cantidad;

            if (br5.Checked)
            {
                descuento = subtotal * 5 / 100;
            }
            if (br0.Checked)
            {
                descuento = 0;
            }
            if (br10.Checked)
            {
                descuento = subtotal * 10 / 100;
            }
            if (cbIva.Checked)
            {
                Iva = (subtotal - descuento) * 19 / 100;
            }
            else
            {
                Iva = 0;
            }

            subtotal = subtotal - descuento + Iva;

            txSalida.Text = txSalida.Text + "\r\n" + cbArticulo.Text + "\t" + txValor.Text+ "\t" + numCantidad.Value + "\t" + descuento + "\t" + Iva + "\t" + subtotal;

            totalTotal = totalTotal + subtotal;
            totalIva = totalIva + Iva;
            totalDescuento = totalDescuento + descuento;
        }

        public Caja()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            string nom_cajero = "";
            int clave = 0;
            if (String.IsNullOrEmpty(txNombre.Text) || String.IsNullOrEmpty(txClave.Text))
            {
                MessageBox.Show("Debe ingresar toda la información");
            }
            else
            {

                nom_cajero = txNombre.Text;
                clave = Int32.Parse(txClave.Text);
                if (clave == 1234)
                {
                    MessageBox.Show("Bienvenido " + nom_cajero);
                    gbCaja.Visible = true;
                    gbLogueo.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Clave incorrecta");
                    txNombre.Clear();
                    txClave.Clear();
                    txNombre.Focus();
                }
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNueva_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txCliente.Text))
            {
                MessageBox.Show("No ingresó el nombre del cliente");
                txCliente.Focus();
            }
            else
            {
                gbFactura.Visible = true;
                gbDatos.Enabled = false;
                totalTotal = 0;
                totalIva = 0;
                totalDescuento = 0;
                DateTime objfecha;
                objfecha = tpFecha.Value;

                string factura = "\tFACTURA DE COMPRA\r\nCliente: " + txCliente.Text + " Sucursal: " + ltSucursal.Text + " Fecha: " + objfecha.Day + "/" + objfecha.Month + "/" + objfecha.Year + "\r\n" + "\r\n" + "Producto\tValor\tCant\tDesc\tIVA\tSubtotal";
                txSalida.Text = factura;
            }
        }
    }
}
