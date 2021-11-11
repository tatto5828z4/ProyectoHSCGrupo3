using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Brayan Cifuentes 9959-18-1113 */
namespace CapaVistaHoteleria
{
    public partial class frmHabitacion : Form
    {
        public frmHabitacion()
        {
            InitializeComponent();

            //Inicializacion
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "habitacion", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //combobox
            navegador1.funLlenarComboControl(cbxTipoHabitacion, "tipoHabitacion", "idTipoHabitacion", "nombre", "estatus");
            navegador1.funLlenarComboControl(cbxTipoCama, "tipoCama", "idTipoCama", "nombre", "estatus");

            //campo estado
            navegador1.campoEstado = "estatus";

            //ayuda 
            navegador1.idAplicacion = "1007";

            //ejecucion de ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";

            //asociacion con reporte
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");

            //tabla datagridview
            navegador1.pideGrid(this.dgvHabitacion);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);

            // Permisos
            navegador1.usuario = nombreUsuario.nombre;
            navegador1.aplicacion = "Mantenimiento Habitación";
            navegador1.funActualizarPermisos();

            navegador1.idmodulo = "1001";

            //ocultar botones
            txtIdTipoHabitacion.Visible = false;
            txtIdTipoCama.Visible = false;
            txtEstatus.Visible = false;

        }

        private void cbxTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxTipoHabitacion, txtIdTipoHabitacion);
        }

        private void txtIdTipoHabitacion_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxTipoHabitacion, txtIdTipoHabitacion);
        }

        private void cbxTipoCama_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxTipoCama, txtIdTipoCama);
        }

        private void txtIdTipoCama_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxTipoCama, txtIdTipoCama);
        }

        private void rbtActivo_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, rbtActivo, "A");
        }

        private void rbtInactivo_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, rbtInactivo, "I");
        }

        private void txtEstatus_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rbtActivo, rbtInactivo, txtEstatus);
        }

        private void dgvHabitacion_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dgvHabitacion);
        }

        private void frmHabitacion_Load(object sender, EventArgs e)
        {

        }
    }
}
