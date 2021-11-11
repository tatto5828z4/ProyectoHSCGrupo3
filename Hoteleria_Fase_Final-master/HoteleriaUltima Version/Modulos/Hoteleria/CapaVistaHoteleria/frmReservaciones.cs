using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaHoteleria
{
    public partial class frmReservaciones : Form
    {
        public frmReservaciones()
        {
            InitializeComponent();

            //Inicializacion
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "reservacion", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //combobox
            navegador1.funLlenarComboControl(cbxCliente, "cliente", "pkid", "nombre", "estatus");
            navegador1.funLlenarComboControl(cbxHabitacion, "habitacion", "idHabitacion", "idHabitacion", "estatus");



            //Dar de baja 
            navegador1.campoEstado = "estatus";

            //ayuda 
            navegador1.idAplicacion = "1011";

            //ejecucion de ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";

            //asociacion con reporte
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");

            //tabla datagridview
            navegador1.pideGrid(this.dgvReservacion);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);

            
            // Permisos
            navegador1.usuario = nombreUsuario.nombre;
            navegador1.aplicacion = "Proceso Reservacion";
            navegador1.funActualizarPermisos();

            navegador1.idmodulo = "1001";


            //ocualtando textbox de apoyo 
            txtIdCliente.Visible = false;
            txtIdHabitacion.Visible = false;
            txtFechaInicio.Visible = false;
            txtFechaFin.Visible = false;
            txtEstatus.Visible = false;

        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxCliente, txtIdCliente);
        }

        private void cbxHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxHabitacion, txtIdHabitacion);
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxCliente, txtIdCliente);
        }

        private void txtIdHabitacion_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxHabitacion, txtIdHabitacion);
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            navegador1.funDPTextBoxVista(dtpFechaInicio, txtFechaInicio);
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            navegador1.funDPTextBoxVista(dtpFechaFin, txtFechaFin);
        }

        private void txtFechaInicio_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextBoxDPTVista(dtpFechaInicio, txtFechaInicio);
            navegador1.funDPTextBoxVista(dtpFechaInicio, txtFechaInicio);
        }

        private void txtFechaFin_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextBoxDPTVista(dtpFechaFin, txtFechaFin);
            navegador1.funDPTextBoxVista(dtpFechaFin, txtFechaFin);
        }

        private void rbtActivo_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, rbtActivo, "A");
        }

        private void rbtInactivo_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, rbtInactivo, "I");
        }

        private void rbtCheckin_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, rbtCheckin, "E");
        }

        private void rbcheckout_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, rbcheckout, "O");
        }

        private void txtEstatus_TextChanged(object sender, EventArgs e)
        {
            if (txtEstatus.Text == "O")
            {
                rbcheckout.Checked = true;
            }
            else if (txtEstatus.Text == "E")
            {
                rbtCheckin.Checked = true;
            }
            else if (txtEstatus.Text == "A")
            {
                rbtActivo.Checked = true;
            }
            else if (txtEstatus.Text == "I")
            {
                rbtInactivo.Checked = true;
            }
        }

        private void dgvReservacion_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dgvReservacion);
        }

        private void frmReservaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
