using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorMVentasCC;
using BitacoraUsuario;
using static datosUsuario;
using System.Data.Odbc;
//Heydi Quemé 9959-18-5335
namespace CapaVistaMVentasCC
{
	public partial class frmPedido : Form
	{
		Bitacora loggear = new Bitacora();
		ControladorFacturacion con = new ControladorFacturacion();
		string estado = "";
		string permisos = "";

		public Boolean permisoIngreso = true;  //Valor que debe llegar de seguridad
		public Boolean permisoModificar = true;  //Valor que debe llegar de seguridad
		public Boolean permisoEliminar = true;  //Valor que debe llegar de seguridad
		public Boolean permisoConsultar = true;  //Valor que debe llegar de seguridad
		public Boolean permisoReporteador = true;  //Valor que debe llegar de seguridad

		public frmPedido()
		{
			InitializeComponent();

			//string Usuario = "admin";
			//IdUsuario = loggear.obtenerIdDeUsuario(Usuario);

			permisos = bloqueo(IdUsuario, "3004");
			funActualizarPermisos();

			loggear.guardarEnBitacora(IdUsuario, "3001", "3004", "Acceso a Pedidos");


			llenarcbxna(cbxBodega, "Cliente", "estatus");
			llenarcbx(cbxNombre, "Cliente", "pkid", "nombre", "estatus", "Elija un Cliente", 1);
			llenarcbx(cbxApellido, "Cliente", "pkid", "apellido", "estatus", "Elija un Cliente", 3);
			llenarcbx(cbxBodega2, "Bodega", "pkid", "nombre", "estado", "Seleccione una Bodega", 2);
			llenarcbx(cbxProducto, "Producto", "pkid", "nombre", "estatus", "Seleccione un Producto", 2);
			actualizardatagriew("PedidoEncabezado", "PedidoDetalle", dtgPedidosE, dtgPedidosD);
			txtstock.Enabled = false;
			btncambioestado.Enabled = false;
			btncancelarcambio.Enabled = false;
			btnCancelar.Enabled = false;
		}

		public void consultaId(TextBox txt, string tabla, string nombre, string apellido, string dato)
		{
			con.consultaid(txt, tabla, nombre, apellido, dato);
		}
		public void consultaIda(TextBox txt, string tabla, string nombre, string dato, string condicion)
		{
			con.consultaida(txt, tabla, nombre, dato, condicion);
		}
		public void llenarcbx(ComboBox cbx, string tabla, string value, string display, string estatus, string inicial, int i)
		{

			try
			{
				cbx.Items.Clear();
				OdbcDataReader datareader = con.llenarcbxna(tabla, estatus);
				cbx.Items.Add(inicial);
				while (datareader.Read())
				{
					cbx.Items.Add(datareader[i].ToString());
				}
				cbx.SelectedIndex = 0;
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}


		public void llenarcbxna(ComboBox cbx, string tabla, string estatus)
		{

			try
			{
				cbx.Items.Clear();
				OdbcDataReader datareader = con.llenarcbxna(tabla, estatus);
				cbx.Items.Add("Selecione un Cliente");
				while (datareader.Read())
				{
					cbx.Items.Add(datareader[1].ToString() + " " + datareader[3].ToString());
				}
				cbx.SelectedIndex = 0;
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}


		public void igualarid()
		{
			txtFkpedido.Text = txtIdpedido.Text;
		}

		public void actualizardatagriew(string tabla1, string tabla2, DataGridView dtg1, DataGridView dtg2)
		{
			DataTable dt = con.llenarDataGrid(tabla1);
			dtg1.DataSource = dt;
			DataTable dt1 = con.llenarDataGrid(tabla2);
			dtg2.DataSource = dt1;
		}

		public void limpiar()
		{
			igualarid();
			txtIdpedido.Enabled = true;
			txtIdpedido.Text = "";
			cbxBodega.Enabled = true;
			cbxBodega2.Enabled = true;
			dtpFechapedido.Enabled = true;
			dtpfechaVencimiento.Enabled = true;
			rbnActiva.Enabled = true;
			rbnVencida.Enabled = true;
			rbnActiva.Checked = false;
			rbnVencida.Checked = false;
			cbxBodega.SelectedIndex = 0;
			cbxBodega2.SelectedIndex = 0;
			dtpFechapedido.Text = string.Empty;
			dtpFechapedido.Checked = false;
			dtpfechaVencimiento.Text = string.Empty;
			dtpfechaVencimiento.Checked = false;

			txtFkpedido.Enabled = true;
			txtFkpedido.Text = "";

			estado = "";

			//focus
			txtIdpedido.Focus();
		}

		public void bloquear()
		{
			igualarid();
			txtIdpedido.Enabled = false;
			cbxBodega.Enabled = false;
			cbxBodega2.Enabled = false;
			dtpFechapedido.Enabled = false;
			dtpfechaVencimiento.Enabled = false;
			rbnActiva.Enabled = false;
			rbnVencida.Enabled = false;

			txtFkpedido.Enabled = false;

			//focus
			txtIddetalle.Focus();
		}

		public string bloqueo(string id, string app)
		{
			string cadena = con.bloqueo(id, app);


			return cadena;
		}

		public void funActualizarPermisos() //Liam Patrick Bernard García 0901-18-10092, Jaime López 0901-18-735
		{

			if (permisos.Length < 5)
			{
				MessageBox.Show("El Usuario no tiene permisos para esta aplicacion.");
				this.Close();
				return;
			}

			if (permisos[0] == '1')
			{
				permisoIngreso = true;
			}
			else
			{
				permisoIngreso = false;
			}

			if (permisos[1] == '1')
			{

			}
			else
			{
				MessageBox.Show("Usted No Tiene Permisos de Lectura");
				this.Close();
			}

			if (permisos[2] == '1')
			{
				permisoReporteador = true;
			}
			else
			{
				permisoReporteador = false;
			}

			if (permisos[3] == '1')
			{
				permisoEliminar = true;
			}
			else
			{
				permisoEliminar = false;
			}

			if (permisos[4] == '1')
			{
				permisoModificar = true;
			}
			else
			{
				permisoModificar = false;
			}

			//btnGuardar.Enabled = false;
			//btnCancelar.Enabled = false;

			//Habilitación de Permisos

			if (permisoIngreso == false)
			{
				btnValidarencabezado.Enabled = false;
				btnInsertar.Enabled = false;
				btnModificar.Enabled = false;
			}
			else
			{
				btnValidarencabezado.Enabled = true;
				btnInsertar.Enabled = true;
				btnModificar.Enabled = true;
			}

			if (permisoModificar == false)
			{
				dtgPedidosE.Enabled = false;
				dtgPedidosD.Enabled = false;
			}
			else
			{
				dtgPedidosE.Enabled = true;
				dtgPedidosD.Enabled = true;
			}

			if (permisoReporteador == false)
			{
				btnReporte.Enabled = false;
			}
			else
			{
				btnReporte.Enabled = true;
			}
		}

		private void btnReporte_Click(object sender, EventArgs e)
		{
			ReportePedidos pedido = new ReportePedidos();
			pedido.Show();
			loggear.guardarEnBitacora(IdUsuario, "3001", "3004", "Acceso a Reporte");
		}

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, "AyudaPedidos/AyudaPedidos.chm", "AyudaPedidos/AyudaPedidos.html");
			loggear.guardarEnBitacora(IdUsuario, "3001", "3004", "Acceso a Ayuda");
		}

		private void cbxBodega_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtfechapedido.Text = dtpFechapedido.Value.ToString("yyyy-MM-dd");
			txtfechavencimiento.Text = dtpfechaVencimiento.Value.ToString("yyyy-MM-dd");
			if (cbxBodega.SelectedIndex != 0)
			{
				int seleccion = cbxBodega.SelectedIndex;
				cbxNombre.SelectedIndex = seleccion;
				cbxApellido.SelectedIndex = seleccion;
				consultaId(txtidbodega, "Cliente", cbxNombre.Text, cbxApellido.Text, "Pkid");
			}
			else
			{
				txtidbodega.Text = "";
			}
		}

		private void cbxBodega2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxBodega2.Text != "Seleccione una Bodega")
			{
				consultaIda(txtBodega2, "Bodega", cbxBodega2.Text, "pkid", "nombre");
			}
			else
			{
				txtBodega2.Text = "";
			}
		}

		private void dtpFechapedido_ValueChanged(object sender, EventArgs e)
		{
			txtfechapedido.Text = dtpFechapedido.Value.ToString("yyyy-MM-dd");
		}

		private void rbnActiva_CheckedChanged(object sender, EventArgs e)
		{
			estado = "A";
			txtfechapedido.Text = dtpFechapedido.Value.ToString("yyyy-MM-dd");
		}

		private void rbnVencida_CheckedChanged(object sender, EventArgs e)
		{
			estado = "I";
		}

		private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxProducto.Text != "Seleccione un Producto")
			{
				consultaIda(txtidproducto, "Producto", cbxProducto.Text, "pkid", "nombre");
				consultaIda(txtstock, "Producto", cbxProducto.Text, "stock", "nombre");
			}
			else
			{
				txtidproducto.Text = "";
				txtstock.Text = "";
			}
		}

		private void dtpfechaVencimiento_ValueChanged(object sender, EventArgs e)
		{
			txtfechavencimiento.Text = dtpfechaVencimiento.Value.ToString("yyyy-MM-dd");
		}

		private void btnValidarencabezado_Click(object sender, EventArgs e)
		{
			if (txtIdpedido.Text == "")
			{
				MessageBox.Show("Debe ingresar un ID para el pedido.");
			}
			else if (cbxBodega.SelectedIndex == 0)
			{
				MessageBox.Show("Debe seleccionar un cliente.");
			}
			else if (cbxBodega2.SelectedIndex == 0)
			{
				MessageBox.Show("Debe seleccionar una bodega.");
			}
			else if (dtpFechapedido.Value.Date == dtpfechaVencimiento.Value.Date)
			{
				MessageBox.Show("Debe seleccionar una fecha límite de entrega próxima a la de generación de pedido.");
			}
			else if (dtpFechapedido.Value.Date > dtpfechaVencimiento.Value.Date)
			{
				MessageBox.Show("La fecha límite de entrega no puede ser anterior a la de generación de pedido.");
			}
			else if (estado == "" || estado == "I")
			{
				MessageBox.Show("Debe seleccionar un estado para el pedido o ha elegido un estado inválido por el momento.");
			}
			else
			{

				int ret = con.insertarEncabezadoP("PedidoEncabezado", txtIdpedido.Text, txtidbodega.Text, txtBodega2.Text, txtfechapedido.Text, txtfechavencimiento.Text, estado);

				if (ret == 1)
				{
					loggear.guardarEnBitacora(IdUsuario, "3001", "3004", "Pedido " + txtIdpedido.Text + " Ingresado");
					actualizardatagriew("PedidoEncabezado", "PedidoDetalle", dtgPedidosE, dtgPedidosD);
					bloquear();

					if (permisoEliminar == false)
					{
						btnCancelar.Enabled = false;
					}
					else
					{
						btnCancelar.Enabled = true;
					}
					btnValidarencabezado.Enabled = false;
				}
				else
				{
					limpiar();
				}
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			try
			{
				con.eliminar("PedidoDetalle", txtFkpedido.Text, "fkidpedido");
				loggear.guardarEnBitacora(IdUsuario, "3001", "3004", "Pedido N° " + txtIdpedido.Text + " cancelado con sus detalles relacionados");
			}
			catch (Exception excep)
			{
				MessageBox.Show("Sin detalles relacionados al pedido cancelado");
				loggear.guardarEnBitacora(IdUsuario, "3001", "3004", "Pedido N° " + txtIdpedido.Text + " cancelado sin detalles relacionados");
			}
			con.eliminar("PedidoEncabezado", txtIdpedido.Text, "pkid");
			actualizardatagriew("PedidoEncabezado", "PedidoDetalle", dtgPedidosE, dtgPedidosD);
			limpiar();
			btnValidarencabezado.Enabled = true;
			btnCancelar.Enabled = false;
		}

		private void btncambioestado_Click(object sender, EventArgs e)
		{
			int ret = con.modifEncabezadoP("PedidoEncabezado", txtIdpedido.Text, estado);

			if (ret == 1)
			{
				actualizardatagriew("PedidoEncabezado", "PedidoDetalle", dtgPedidosE, dtgPedidosD);
				loggear.guardarEnBitacora(IdUsuario, "3001", "3004", "Estado del Pedido N° " + txtIdpedido.Text + " modificado");
				limpiar();
				btncancelarcambio.Enabled = false;
				btncambioestado.Enabled = false;
				btnCancelar.Enabled = true;
				btnValidarencabezado.Enabled = true;
			}
			else
			{
				limpiar();
				btncancelarcambio.Enabled = false;
				btncambioestado.Enabled = false;
				btnCancelar.Enabled = false;
				btnValidarencabezado.Enabled = true;
			}
		}

		private void btncancelarcambio_Click(object sender, EventArgs e)
		{
			loggear.guardarEnBitacora(IdUsuario, "3001", "3004", "Modificación del estado del Pedido N° " + txtIdpedido.Text + " cancelada");
			limpiar();
			btncancelarcambio.Enabled = false;
			btncambioestado.Enabled = false;
			btnCancelar.Enabled = false;
			btnValidarencabezado.Enabled = true;
		}

		private void btnInsertar_Click(object sender, EventArgs e)
		{
			if (txtIddetalle.Text == "")
			{
				MessageBox.Show("Debe ingresar un ID para el detalle.");
			}
			else if (txtFkpedido.Text == "")
			{
				MessageBox.Show("Debe generar un ID de pedido antes de ingresar detalles.");
			}
			else if (txtCantidad.Text == "")
			{
				MessageBox.Show("Debe ingresar una cantidad para agregar el detalle al pedido.");
			}
			else if (int.Parse(txtCantidad.Text) > int.Parse(txtstock.Text))
			{
				MessageBox.Show("La cantidad solicitada no puede exceder a la existencia disponible.");
			}
			else if (cbxProducto.SelectedIndex == 0)
			{
				MessageBox.Show("Debe seleccionar un producto.");
			}
			else
			{
				int ret = con.insertarDetalleP("PedidoDetalle", txtIddetalle.Text, txtFkpedido.Text, txtCantidad.Text, txtidproducto.Text);

				if (ret == 1)
				{
					actualizardatagriew("PedidoEncabezado", "PedidoDetalle", dtgPedidosE, dtgPedidosD);
					loggear.guardarEnBitacora(IdUsuario, "3001", "3004", "Detalle de pedido N° " + txtIddetalle.Text + " añadido");
					txtIddetalle.Text = "";
					txtCantidad.Text = "";
					cbxProducto.SelectedIndex = 0;
				}
				else
				{
					txtIddetalle.Text = "";
					txtCantidad.Text = "";
					cbxProducto.SelectedIndex = 0;

				}
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtIddetalle.Text = "";
			txtCantidad.Text = "";
			cbxProducto.SelectedIndex = 0;

			loggear.guardarEnBitacora(IdUsuario, "3001", "3004", "Sección de detalle de pedido limpiado.");
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			loggear.guardarEnBitacora(IdUsuario, "3001", "3004", "Pedido N° " + txtIdpedido.Text + " finalizado");
			limpiar();
			txtIddetalle.Text = "";
			txtCantidad.Text = "";
			cbxProducto.SelectedIndex = 0;
			txtFkpedido.Text = "";

			txtFkpedido.Enabled = true;
		}

		private void dtgPedidosE_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtIdpedido.Text = dtgPedidosE.CurrentRow.Cells[0].Value.ToString();
			txtidbodega.Text = dtgPedidosE.CurrentRow.Cells[1].Value.ToString();

			cbxNombre.SelectedIndex = int.Parse(txtidbodega.Text);
			cbxApellido.SelectedIndex = int.Parse(txtidbodega.Text);
			int seleccion = cbxNombre.SelectedIndex;
			cbxBodega.SelectedIndex = seleccion;

			txtBodega2.Text = dtgPedidosE.CurrentRow.Cells[2].Value.ToString();
			cbxBodega2.SelectedIndex = int.Parse(txtBodega2.Text);
			dtpFechapedido.Text = dtgPedidosE.CurrentRow.Cells[3].Value.ToString();
			dtpfechaVencimiento.Text = dtgPedidosE.CurrentRow.Cells[4].Value.ToString();
			string est = dtgPedidosE.CurrentRow.Cells[5].Value.ToString();

			if (est == "A")
			{
				rbnActiva.Checked = true;
			}
			else if (est == "I")
			{
				rbnVencida.Checked = true;
			}
			txtIdpedido.Enabled = false;
			cbxBodega.Enabled = false;
			cbxBodega2.Enabled = false;
			dtpfechaVencimiento.Enabled = false;
			dtpFechapedido.Enabled = false;
			btncambioestado.Enabled = true;
			btncancelarcambio.Enabled = true;
			btnCancelar.Enabled = false;
			btnValidarencabezado.Enabled = false;
			loggear.guardarEnBitacora(IdUsuario, "3001", "3004", "Encabezado de pedido N° " + txtIdpedido.Text + " seleccionado");
		}
	}
}
