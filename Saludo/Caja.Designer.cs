
namespace Saludo
{
    partial class Caja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbLogueo = new System.Windows.Forms.GroupBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btEnviar = new System.Windows.Forms.Button();
            this.txClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.gbCaja = new System.Windows.Forms.GroupBox();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.valorEfecivo = new System.Windows.Forms.Label();
            this.btPagar = new System.Windows.Forms.Button();
            this.txPago = new System.Windows.Forms.TextBox();
            this.btFin = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.txSalida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbIva = new System.Windows.Forms.CheckBox();
            this.br10 = new System.Windows.Forms.RadioButton();
            this.br5 = new System.Windows.Forms.RadioButton();
            this.br0 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbArticulo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btCerrarS = new System.Windows.Forms.Button();
            this.btNueva = new System.Windows.Forms.Button();
            this.ltSucursal = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpFecha = new System.Windows.Forms.DateTimePicker();
            this.txCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbLogueo.SuspendLayout();
            this.gbCaja.SuspendLayout();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogueo
            // 
            this.gbLogueo.Controls.Add(this.btBorrar);
            this.gbLogueo.Controls.Add(this.btEnviar);
            this.gbLogueo.Controls.Add(this.txClave);
            this.gbLogueo.Controls.Add(this.label3);
            this.gbLogueo.Controls.Add(this.txNombre);
            this.gbLogueo.Controls.Add(this.label2);
            this.gbLogueo.Location = new System.Drawing.Point(22, 51);
            this.gbLogueo.Name = "gbLogueo";
            this.gbLogueo.Size = new System.Drawing.Size(657, 122);
            this.gbLogueo.TabIndex = 0;
            this.gbLogueo.TabStop = false;
            this.gbLogueo.Text = "LOGUEO";
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(432, 63);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(88, 25);
            this.btBorrar.TabIndex = 5;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(432, 15);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(88, 25);
            this.btEnviar.TabIndex = 4;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // txClave
            // 
            this.txClave.Location = new System.Drawing.Point(83, 68);
            this.txClave.Name = "txClave";
            this.txClave.PasswordChar = '*';
            this.txClave.Size = new System.Drawing.Size(234, 20);
            this.txClave.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave:";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(83, 19);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(234, 20);
            this.txNombre.TabIndex = 1;
            this.txNombre.TextChanged += new System.EventHandler(this.txNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROGRAMA CAJA REGISTRADORA";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(685, 71);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(88, 68);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // gbCaja
            // 
            this.gbCaja.Controls.Add(this.gbFactura);
            this.gbCaja.Controls.Add(this.gbDatos);
            this.gbCaja.Location = new System.Drawing.Point(22, 211);
            this.gbCaja.Name = "gbCaja";
            this.gbCaja.Size = new System.Drawing.Size(736, 480);
            this.gbCaja.TabIndex = 6;
            this.gbCaja.TabStop = false;
            this.gbCaja.Text = "Caja Registradora";
            this.gbCaja.Visible = false;
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.valorEfecivo);
            this.gbFactura.Controls.Add(this.btPagar);
            this.gbFactura.Controls.Add(this.txPago);
            this.gbFactura.Controls.Add(this.btFin);
            this.gbFactura.Controls.Add(this.btAgregar);
            this.gbFactura.Controls.Add(this.txSalida);
            this.gbFactura.Controls.Add(this.label11);
            this.gbFactura.Controls.Add(this.cbIva);
            this.gbFactura.Controls.Add(this.br10);
            this.gbFactura.Controls.Add(this.br5);
            this.gbFactura.Controls.Add(this.br0);
            this.gbFactura.Controls.Add(this.label10);
            this.gbFactura.Controls.Add(this.numCantidad);
            this.gbFactura.Controls.Add(this.label9);
            this.gbFactura.Controls.Add(this.txValor);
            this.gbFactura.Controls.Add(this.label8);
            this.gbFactura.Controls.Add(this.cbArticulo);
            this.gbFactura.Controls.Add(this.label7);
            this.gbFactura.Location = new System.Drawing.Point(15, 177);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(703, 285);
            this.gbFactura.TabIndex = 1;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Facturación";
            this.gbFactura.Visible = false;
            // 
            // valorEfecivo
            // 
            this.valorEfecivo.AutoSize = true;
            this.valorEfecivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorEfecivo.Location = new System.Drawing.Point(606, 131);
            this.valorEfecivo.Name = "valorEfecivo";
            this.valorEfecivo.Size = new System.Drawing.Size(81, 15);
            this.valorEfecivo.TabIndex = 17;
            this.valorEfecivo.Text = "Su efectivo:";
            this.valorEfecivo.Visible = false;
            this.valorEfecivo.Click += new System.EventHandler(this.label12_Click);
            // 
            // btPagar
            // 
            this.btPagar.Location = new System.Drawing.Point(601, 175);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(86, 36);
            this.btPagar.TabIndex = 16;
            this.btPagar.Text = "Pagar";
            this.btPagar.UseVisualStyleBackColor = true;
            this.btPagar.Visible = false;
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // txPago
            // 
            this.txPago.Location = new System.Drawing.Point(601, 149);
            this.txPago.Name = "txPago";
            this.txPago.Size = new System.Drawing.Size(86, 20);
            this.txPago.TabIndex = 15;
            this.txPago.Visible = false;
            this.txPago.TextChanged += new System.EventHandler(this.txPago_TextChanged);
            // 
            // btFin
            // 
            this.btFin.Location = new System.Drawing.Point(601, 76);
            this.btFin.Name = "btFin";
            this.btFin.Size = new System.Drawing.Size(86, 42);
            this.btFin.TabIndex = 14;
            this.btFin.Text = "Fin factura";
            this.btFin.UseVisualStyleBackColor = true;
            this.btFin.Click += new System.EventHandler(this.btFin_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(601, 21);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(86, 49);
            this.btAgregar.TabIndex = 13;
            this.btAgregar.Text = "Agregar producto";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // txSalida
            // 
            this.txSalida.Location = new System.Drawing.Point(24, 122);
            this.txSalida.Multiline = true;
            this.txSalida.Name = "txSalida";
            this.txSalida.ReadOnly = true;
            this.txSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txSalida.Size = new System.Drawing.Size(534, 157);
            this.txSalida.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Salida:";
            // 
            // cbIva
            // 
            this.cbIva.AutoSize = true;
            this.cbIva.Location = new System.Drawing.Point(330, 81);
            this.cbIva.Name = "cbIva";
            this.cbIva.Size = new System.Drawing.Size(43, 17);
            this.cbIva.TabIndex = 10;
            this.cbIva.Text = "IVA";
            this.cbIva.UseVisualStyleBackColor = true;
            // 
            // br10
            // 
            this.br10.AutoSize = true;
            this.br10.Location = new System.Drawing.Point(180, 81);
            this.br10.Name = "br10";
            this.br10.Size = new System.Drawing.Size(45, 17);
            this.br10.TabIndex = 9;
            this.br10.Text = "10%";
            this.br10.UseVisualStyleBackColor = true;
            // 
            // br5
            // 
            this.br5.AutoSize = true;
            this.br5.Location = new System.Drawing.Point(135, 81);
            this.br5.Name = "br5";
            this.br5.Size = new System.Drawing.Size(39, 17);
            this.br5.TabIndex = 8;
            this.br5.Text = "5%";
            this.br5.UseVisualStyleBackColor = true;
            // 
            // br0
            // 
            this.br0.AutoSize = true;
            this.br0.Checked = true;
            this.br0.Location = new System.Drawing.Point(90, 81);
            this.br0.Name = "br0";
            this.br0.Size = new System.Drawing.Size(39, 17);
            this.br0.TabIndex = 7;
            this.br0.TabStop = true;
            this.br0.Text = "0%";
            this.br0.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Descuento:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(452, 37);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(36, 20);
            this.numCantidad.TabIndex = 5;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cantidad:";
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(298, 38);
            this.txValor.Name = "txValor";
            this.txValor.ReadOnly = true;
            this.txValor.Size = new System.Drawing.Size(72, 20);
            this.txValor.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Valor (c/u):";
            // 
            // cbArticulo
            // 
            this.cbArticulo.FormattingEnabled = true;
            this.cbArticulo.Items.AddRange(new object[] {
            "Pantalón",
            "Camisa",
            "Falda",
            "Medias"});
            this.cbArticulo.Location = new System.Drawing.Point(84, 37);
            this.cbArticulo.Name = "cbArticulo";
            this.cbArticulo.Size = new System.Drawing.Size(121, 21);
            this.cbArticulo.TabIndex = 1;
            this.cbArticulo.SelectedIndexChanged += new System.EventHandler(this.cbArticulo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Producto: ";
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDatos.Controls.Add(this.btCerrarS);
            this.gbDatos.Controls.Add(this.btNueva);
            this.gbDatos.Controls.Add(this.ltSucursal);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.tpFecha);
            this.gbDatos.Controls.Add(this.txCliente);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Location = new System.Drawing.Point(15, 36);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(703, 115);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos cliente";
            // 
            // btCerrarS
            // 
            this.btCerrarS.Location = new System.Drawing.Point(452, 69);
            this.btCerrarS.Name = "btCerrarS";
            this.btCerrarS.Size = new System.Drawing.Size(106, 23);
            this.btCerrarS.TabIndex = 7;
            this.btCerrarS.Text = "Cerrar cesión";
            this.btCerrarS.UseVisualStyleBackColor = true;
            this.btCerrarS.Click += new System.EventHandler(this.btCerrarS_Click);
            // 
            // btNueva
            // 
            this.btNueva.Location = new System.Drawing.Point(452, 29);
            this.btNueva.Name = "btNueva";
            this.btNueva.Size = new System.Drawing.Size(106, 23);
            this.btNueva.TabIndex = 6;
            this.btNueva.Text = "Nueva factura";
            this.btNueva.UseVisualStyleBackColor = true;
            this.btNueva.Click += new System.EventHandler(this.btNueva_Click);
            // 
            // ltSucursal
            // 
            this.ltSucursal.FormattingEnabled = true;
            this.ltSucursal.Items.AddRange(new object[] {
            "Bello",
            "Medellin",
            "Itagui",
            "Envigado",
            "Sabaneta"});
            this.ltSucursal.Location = new System.Drawing.Point(276, 32);
            this.ltSucursal.Name = "ltSucursal";
            this.ltSucursal.Size = new System.Drawing.Size(120, 69);
            this.ltSucursal.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sucursal: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha: ";
            // 
            // tpFecha
            // 
            this.tpFecha.Location = new System.Drawing.Point(127, 32);
            this.tpFecha.Name = "tpFecha";
            this.tpFecha.Size = new System.Drawing.Size(138, 20);
            this.tpFecha.TabIndex = 2;
            // 
            // txCliente
            // 
            this.txCliente.Location = new System.Drawing.Point(21, 32);
            this.txCliente.Name = "txCliente";
            this.txCliente.Size = new System.Drawing.Size(100, 20);
            this.txCliente.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre del cliente: ";
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.gbCaja);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbLogueo);
            this.Name = "Caja";
            this.Text = "Caja";
            this.gbLogueo.ResumeLayout(false);
            this.gbLogueo.PerformLayout();
            this.gbCaja.ResumeLayout(false);
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogueo;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.TextBox txClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.GroupBox gbCaja;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txCliente;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.Button btCerrarS;
        private System.Windows.Forms.Button btNueva;
        private System.Windows.Forms.ListBox ltSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tpFecha;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txSalida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbIva;
        private System.Windows.Forms.RadioButton br10;
        private System.Windows.Forms.RadioButton br5;
        private System.Windows.Forms.RadioButton br0;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btPagar;
        private System.Windows.Forms.TextBox txPago;
        private System.Windows.Forms.Button btFin;
        private System.Windows.Forms.Label valorEfecivo;
    }
}