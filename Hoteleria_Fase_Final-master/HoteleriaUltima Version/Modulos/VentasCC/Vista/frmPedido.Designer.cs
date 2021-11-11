
namespace CapaVistaMVentasCC
{
	partial class frmPedido
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
			this.btnAyuda = new System.Windows.Forms.Button();
			this.btnReporte = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label15 = new System.Windows.Forms.Label();
			this.txtstock = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dtgPedidosD = new System.Windows.Forms.DataGridView();
			this.btnModificar = new System.Windows.Forms.Button();
			this.dtgPedidosE = new System.Windows.Forms.DataGridView();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.txtidproducto = new System.Windows.Forms.TextBox();
			this.txtFkpedido = new System.Windows.Forms.TextBox();
			this.cbxProducto = new System.Windows.Forms.ComboBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtIddetalle = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbxApellido = new System.Windows.Forms.ComboBox();
			this.cbxNombre = new System.Windows.Forms.ComboBox();
			this.btncancelarcambio = new System.Windows.Forms.Button();
			this.btncambioestado = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnValidarencabezado = new System.Windows.Forms.Button();
			this.txtBodega2 = new System.Windows.Forms.TextBox();
			this.cbxBodega2 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtfechavencimiento = new System.Windows.Forms.TextBox();
			this.txtidbodega = new System.Windows.Forms.TextBox();
			this.txtfechapedido = new System.Windows.Forms.TextBox();
			this.dtpfechaVencimiento = new System.Windows.Forms.DateTimePicker();
			this.dtpFechapedido = new System.Windows.Forms.DateTimePicker();
			this.rbnVencida = new System.Windows.Forms.RadioButton();
			this.rbnActiva = new System.Windows.Forms.RadioButton();
			this.cbxBodega = new System.Windows.Forms.ComboBox();
			this.txtIdpedido = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lblIdcotizacion = new System.Windows.Forms.Label();
			this.lblIdEmpleado = new System.Windows.Forms.Label();
			this.lblIdcliente = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgPedidosD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgPedidosE)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAyuda
			// 
			this.btnAyuda.Location = new System.Drawing.Point(93, 5);
			this.btnAyuda.Name = "btnAyuda";
			this.btnAyuda.Size = new System.Drawing.Size(75, 23);
			this.btnAyuda.TabIndex = 19;
			this.btnAyuda.Text = "Ayuda";
			this.btnAyuda.UseVisualStyleBackColor = true;
			this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
			// 
			// btnReporte
			// 
			this.btnReporte.Location = new System.Drawing.Point(12, 5);
			this.btnReporte.Name = "btnReporte";
			this.btnReporte.Size = new System.Drawing.Size(75, 23);
			this.btnReporte.TabIndex = 18;
			this.btnReporte.Text = "Reporte";
			this.btnReporte.UseVisualStyleBackColor = true;
			this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.txtstock);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.dtgPedidosD);
			this.panel2.Controls.Add(this.btnModificar);
			this.panel2.Controls.Add(this.dtgPedidosE);
			this.panel2.Controls.Add(this.btnLimpiar);
			this.panel2.Controls.Add(this.btnInsertar);
			this.panel2.Controls.Add(this.txtidproducto);
			this.panel2.Controls.Add(this.txtFkpedido);
			this.panel2.Controls.Add(this.cbxProducto);
			this.panel2.Controls.Add(this.txtCantidad);
			this.panel2.Controls.Add(this.txtIddetalle);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Location = new System.Drawing.Point(12, 229);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(728, 399);
			this.panel2.TabIndex = 17;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(450, 196);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(96, 13);
			this.label15.TabIndex = 17;
			this.label15.Text = "Detalles de Pedido";
			// 
			// txtstock
			// 
			this.txtstock.Location = new System.Drawing.Point(67, 114);
			this.txtstock.Name = "txtstock";
			this.txtstock.Size = new System.Drawing.Size(145, 20);
			this.txtstock.TabIndex = 38;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(450, 4);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 13);
			this.label14.TabIndex = 16;
			this.label14.Text = "Pedidos Extendidos";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(4, 117);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 37;
			this.label6.Text = "Stock:";
			// 
			// dtgPedidosD
			// 
			this.dtgPedidosD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgPedidosD.Location = new System.Drawing.Point(249, 212);
			this.dtgPedidosD.Name = "dtgPedidosD";
			this.dtgPedidosD.Size = new System.Drawing.Size(466, 178);
			this.dtgPedidosD.TabIndex = 15;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(67, 190);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(103, 23);
			this.btnModificar.TabIndex = 36;
			this.btnModificar.Text = "Finalizar Pedido";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// dtgPedidosE
			// 
			this.dtgPedidosE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgPedidosE.Location = new System.Drawing.Point(249, 18);
			this.dtgPedidosE.Name = "dtgPedidosE";
			this.dtgPedidosE.Size = new System.Drawing.Size(466, 174);
			this.dtgPedidosE.TabIndex = 14;
			this.dtgPedidosE.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgPedidosE_RowHeaderMouseClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(127, 148);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(103, 23);
			this.btnLimpiar.TabIndex = 35;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnInsertar
			// 
			this.btnInsertar.Location = new System.Drawing.Point(14, 148);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(103, 23);
			this.btnInsertar.TabIndex = 34;
			this.btnInsertar.Text = "Agregar Artículo";
			this.btnInsertar.UseVisualStyleBackColor = true;
			this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
			// 
			// txtidproducto
			// 
			this.txtidproducto.Location = new System.Drawing.Point(224, 79);
			this.txtidproducto.Name = "txtidproducto";
			this.txtidproducto.Size = new System.Drawing.Size(19, 20);
			this.txtidproducto.TabIndex = 33;
			this.txtidproducto.Visible = false;
			// 
			// txtFkpedido
			// 
			this.txtFkpedido.Location = new System.Drawing.Point(67, 29);
			this.txtFkpedido.Name = "txtFkpedido";
			this.txtFkpedido.Size = new System.Drawing.Size(145, 20);
			this.txtFkpedido.TabIndex = 23;
			// 
			// cbxProducto
			// 
			this.cbxProducto.FormattingEnabled = true;
			this.cbxProducto.Location = new System.Drawing.Point(67, 81);
			this.cbxProducto.Name = "cbxProducto";
			this.cbxProducto.Size = new System.Drawing.Size(145, 21);
			this.cbxProducto.TabIndex = 21;
			this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(67, 55);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(145, 20);
			this.txtCantidad.TabIndex = 19;
			// 
			// txtIddetalle
			// 
			this.txtIddetalle.Location = new System.Drawing.Point(67, 3);
			this.txtIddetalle.Name = "txtIddetalle";
			this.txtIddetalle.Size = new System.Drawing.Size(145, 20);
			this.txtIddetalle.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(4, 58);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Cantidad:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(4, 82);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 13);
			this.label10.TabIndex = 15;
			this.label10.Text = "Producto:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 28);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(58, 13);
			this.label11.TabIndex = 14;
			this.label11.Text = "Pedido N°:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(4, 3);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(21, 13);
			this.label12.TabIndex = 13;
			this.label12.Text = "ID:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.cbxApellido);
			this.panel1.Controls.Add(this.cbxNombre);
			this.panel1.Controls.Add(this.btncancelarcambio);
			this.panel1.Controls.Add(this.btncambioestado);
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.btnValidarencabezado);
			this.panel1.Controls.Add(this.txtBodega2);
			this.panel1.Controls.Add(this.cbxBodega2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtfechavencimiento);
			this.panel1.Controls.Add(this.txtidbodega);
			this.panel1.Controls.Add(this.txtfechapedido);
			this.panel1.Controls.Add(this.dtpfechaVencimiento);
			this.panel1.Controls.Add(this.dtpFechapedido);
			this.panel1.Controls.Add(this.rbnVencida);
			this.panel1.Controls.Add(this.rbnActiva);
			this.panel1.Controls.Add(this.cbxBodega);
			this.panel1.Controls.Add(this.txtIdpedido);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.lblIdcotizacion);
			this.panel1.Controls.Add(this.lblIdEmpleado);
			this.panel1.Controls.Add(this.lblIdcliente);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 34);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(728, 189);
			this.panel1.TabIndex = 16;
			// 
			// cbxApellido
			// 
			this.cbxApellido.FormattingEnabled = true;
			this.cbxApellido.Location = new System.Drawing.Point(193, 151);
			this.cbxApellido.Name = "cbxApellido";
			this.cbxApellido.Size = new System.Drawing.Size(121, 21);
			this.cbxApellido.TabIndex = 38;
			this.cbxApellido.Visible = false;
			// 
			// cbxNombre
			// 
			this.cbxNombre.FormattingEnabled = true;
			this.cbxNombre.Location = new System.Drawing.Point(66, 151);
			this.cbxNombre.Name = "cbxNombre";
			this.cbxNombre.Size = new System.Drawing.Size(121, 21);
			this.cbxNombre.TabIndex = 37;
			this.cbxNombre.Visible = false;
			// 
			// btncancelarcambio
			// 
			this.btncancelarcambio.Location = new System.Drawing.Point(586, 163);
			this.btncancelarcambio.Name = "btncancelarcambio";
			this.btncancelarcambio.Size = new System.Drawing.Size(129, 23);
			this.btncancelarcambio.TabIndex = 36;
			this.btncancelarcambio.Text = "Cancelar Modificación";
			this.btncancelarcambio.UseVisualStyleBackColor = true;
			this.btncancelarcambio.Click += new System.EventHandler(this.btncancelarcambio_Click);
			// 
			// btncambioestado
			// 
			this.btncambioestado.Location = new System.Drawing.Point(471, 163);
			this.btncambioestado.Name = "btncambioestado";
			this.btncambioestado.Size = new System.Drawing.Size(116, 23);
			this.btncambioestado.TabIndex = 35;
			this.btncambioestado.Text = "Modificar Estado";
			this.btncambioestado.UseVisualStyleBackColor = true;
			this.btncambioestado.Click += new System.EventHandler(this.btncambioestado_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(593, 134);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(116, 23);
			this.btnCancelar.TabIndex = 34;
			this.btnCancelar.Text = "Cancelar Pedido";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnValidarencabezado
			// 
			this.btnValidarencabezado.Location = new System.Drawing.Point(471, 134);
			this.btnValidarencabezado.Name = "btnValidarencabezado";
			this.btnValidarencabezado.Size = new System.Drawing.Size(116, 23);
			this.btnValidarencabezado.TabIndex = 25;
			this.btnValidarencabezado.Text = "Validar Pedido";
			this.btnValidarencabezado.UseVisualStyleBackColor = true;
			this.btnValidarencabezado.Click += new System.EventHandler(this.btnValidarencabezado_Click);
			// 
			// txtBodega2
			// 
			this.txtBodega2.Location = new System.Drawing.Point(283, 70);
			this.txtBodega2.Name = "txtBodega2";
			this.txtBodega2.Size = new System.Drawing.Size(19, 20);
			this.txtBodega2.TabIndex = 24;
			this.txtBodega2.Visible = false;
			// 
			// cbxBodega2
			// 
			this.cbxBodega2.FormattingEnabled = true;
			this.cbxBodega2.Location = new System.Drawing.Point(124, 69);
			this.cbxBodega2.Name = "cbxBodega2";
			this.cbxBodega2.Size = new System.Drawing.Size(145, 21);
			this.cbxBodega2.TabIndex = 22;
			this.cbxBodega2.SelectedIndexChanged += new System.EventHandler(this.cbxBodega2_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(2, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Bodega que Abastece:";
			// 
			// txtfechavencimiento
			// 
			this.txtfechavencimiento.Location = new System.Drawing.Point(676, 98);
			this.txtfechavencimiento.Name = "txtfechavencimiento";
			this.txtfechavencimiento.Size = new System.Drawing.Size(19, 20);
			this.txtfechavencimiento.TabIndex = 19;
			this.txtfechavencimiento.Visible = false;
			// 
			// txtidbodega
			// 
			this.txtidbodega.Location = new System.Drawing.Point(285, 38);
			this.txtidbodega.Name = "txtidbodega";
			this.txtidbodega.Size = new System.Drawing.Size(19, 20);
			this.txtidbodega.TabIndex = 18;
			this.txtidbodega.Visible = false;
			// 
			// txtfechapedido
			// 
			this.txtfechapedido.Location = new System.Drawing.Point(310, 98);
			this.txtfechapedido.Name = "txtfechapedido";
			this.txtfechapedido.Size = new System.Drawing.Size(19, 20);
			this.txtfechapedido.TabIndex = 17;
			this.txtfechapedido.Visible = false;
			// 
			// dtpfechaVencimiento
			// 
			this.dtpfechaVencimiento.Location = new System.Drawing.Point(470, 98);
			this.dtpfechaVencimiento.Name = "dtpfechaVencimiento";
			this.dtpfechaVencimiento.Size = new System.Drawing.Size(200, 20);
			this.dtpfechaVencimiento.TabIndex = 15;
			this.dtpfechaVencimiento.ValueChanged += new System.EventHandler(this.dtpfechaVencimiento_ValueChanged);
			// 
			// dtpFechapedido
			// 
			this.dtpFechapedido.Location = new System.Drawing.Point(104, 98);
			this.dtpFechapedido.Name = "dtpFechapedido";
			this.dtpFechapedido.Size = new System.Drawing.Size(200, 20);
			this.dtpFechapedido.TabIndex = 15;
			this.dtpFechapedido.ValueChanged += new System.EventHandler(this.dtpFechapedido_ValueChanged);
			// 
			// rbnVencida
			// 
			this.rbnVencida.AutoSize = true;
			this.rbnVencida.Location = new System.Drawing.Point(485, 50);
			this.rbnVencida.Name = "rbnVencida";
			this.rbnVencida.Size = new System.Drawing.Size(64, 17);
			this.rbnVencida.TabIndex = 14;
			this.rbnVencida.TabStop = true;
			this.rbnVencida.Text = "Vencido";
			this.rbnVencida.UseVisualStyleBackColor = true;
			this.rbnVencida.CheckedChanged += new System.EventHandler(this.rbnVencida_CheckedChanged);
			// 
			// rbnActiva
			// 
			this.rbnActiva.AutoSize = true;
			this.rbnActiva.Location = new System.Drawing.Point(428, 50);
			this.rbnActiva.Name = "rbnActiva";
			this.rbnActiva.Size = new System.Drawing.Size(55, 17);
			this.rbnActiva.TabIndex = 13;
			this.rbnActiva.TabStop = true;
			this.rbnActiva.Text = "Activo";
			this.rbnActiva.UseVisualStyleBackColor = true;
			this.rbnActiva.CheckedChanged += new System.EventHandler(this.rbnActiva_CheckedChanged);
			// 
			// cbxBodega
			// 
			this.cbxBodega.FormattingEnabled = true;
			this.cbxBodega.Location = new System.Drawing.Point(125, 37);
			this.cbxBodega.Name = "cbxBodega";
			this.cbxBodega.Size = new System.Drawing.Size(145, 21);
			this.cbxBodega.TabIndex = 10;
			this.cbxBodega.SelectedIndexChanged += new System.EventHandler(this.cbxBodega_SelectedIndexChanged);
			// 
			// txtIdpedido
			// 
			this.txtIdpedido.Location = new System.Drawing.Point(124, 1);
			this.txtIdpedido.Name = "txtIdpedido";
			this.txtIdpedido.Size = new System.Drawing.Size(145, 20);
			this.txtIdpedido.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(379, 50);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Estado:";
			// 
			// lblIdcotizacion
			// 
			this.lblIdcotizacion.AutoSize = true;
			this.lblIdcotizacion.Location = new System.Drawing.Point(634, 7);
			this.lblIdcotizacion.Name = "lblIdcotizacion";
			this.lblIdcotizacion.Size = new System.Drawing.Size(0, 13);
			this.lblIdcotizacion.TabIndex = 16;
			// 
			// lblIdEmpleado
			// 
			this.lblIdEmpleado.AutoSize = true;
			this.lblIdEmpleado.Location = new System.Drawing.Point(230, 60);
			this.lblIdEmpleado.Name = "lblIdEmpleado";
			this.lblIdEmpleado.Size = new System.Drawing.Size(0, 13);
			this.lblIdEmpleado.TabIndex = 16;
			// 
			// lblIdcliente
			// 
			this.lblIdcliente.AutoSize = true;
			this.lblIdcliente.Location = new System.Drawing.Point(221, 29);
			this.lblIdcliente.Name = "lblIdcliente";
			this.lblIdcliente.Size = new System.Drawing.Size(0, 13);
			this.lblIdcliente.TabIndex = 16;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(369, 101);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(95, 13);
			this.label16.TabIndex = 2;
			this.label16.Text = "Fecha de Entrega:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Fecha de Emisión:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cliente:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID:";
			// 
			// frmPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(746, 634);
			this.Controls.Add(this.btnAyuda);
			this.Controls.Add(this.btnReporte);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmPedido";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "3004 Pedidos";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgPedidosD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgPedidosE)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAyuda;
		private System.Windows.Forms.Button btnReporte;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtstock;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dtgPedidosD;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.DataGridView dtgPedidosE;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnInsertar;
		private System.Windows.Forms.TextBox txtidproducto;
		private System.Windows.Forms.TextBox txtFkpedido;
		private System.Windows.Forms.ComboBox cbxProducto;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtIddetalle;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbxApellido;
		private System.Windows.Forms.ComboBox cbxNombre;
		private System.Windows.Forms.Button btncancelarcambio;
		private System.Windows.Forms.Button btncambioestado;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnValidarencabezado;
		private System.Windows.Forms.TextBox txtBodega2;
		private System.Windows.Forms.ComboBox cbxBodega2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtfechavencimiento;
		private System.Windows.Forms.TextBox txtidbodega;
		private System.Windows.Forms.TextBox txtfechapedido;
		private System.Windows.Forms.DateTimePicker dtpfechaVencimiento;
		private System.Windows.Forms.DateTimePicker dtpFechapedido;
		private System.Windows.Forms.RadioButton rbnVencida;
		private System.Windows.Forms.RadioButton rbnActiva;
		private System.Windows.Forms.ComboBox cbxBodega;
		private System.Windows.Forms.TextBox txtIdpedido;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblIdcotizacion;
		private System.Windows.Forms.Label lblIdEmpleado;
		private System.Windows.Forms.Label lblIdcliente;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}