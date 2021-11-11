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
    public partial class frmMesa : Form
    {
        public frmMesa()
        {
            InitializeComponent();

            //Inicializacion
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "mesa", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //combobox
            navegador1.funLlenarComboControl(cbxSalon, "salon", "idSalon", "nombre", "estatus");

            //Dar de baja 
            navegador1.campoEstado = "estado";

            //ayuda 
            navegador1.idAplicacion = "1010";

            //ejecucion de ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";

            //asociacion con reporte
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");

            //tabla Data grid view
            navegador1.pideGrid(dgvMesa);
            navegador1.llenaTabla();

            //referencia a la forma para que el navegador pueda cerrarla
            navegador1.pedirRef(this);

            // Permisos
            navegador1.usuario = nombreUsuario.nombre;
            navegador1.aplicacion = "Mantenimiento Mesa";
            navegador1.funActualizarPermisos();

            navegador1.idmodulo = "1001";

            //ocultar botones
            txtIdSalon.Visible = false;
            txtEstado.Visible = false;
            txtEstatus2.Visible = false;
        }

        private void cbxSalon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxSalon_SelectedValueChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxSalon, txtIdSalon);
        }

        private void txtIdSalon_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxSalon, txtIdSalon);
        }

        private void rbtActivo_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, rbtActivo, "A");
        }

        private void rbtInactivo_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, rbtInactivo, "I");
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rbtActivo, rbtInactivo, txtEstado);
        }

        private void rbtDisponible_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus2, rbtDisponible, "D");
        }

        private void rbtOcupada_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus2, rbtOcupada, "O");
        }

        private void txtEstatus2_TextChanged(object sender, EventArgs e)
        {
            if (txtEstatus2.Text == "O")
            {
                rbtOcupada.Checked = true;
            }
            else if (txtEstatus2.Text == "D")
            {
                rbtDisponible.Checked = true;
            }
        }

        private void dgvMesa_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dgvMesa);
        }

        private void frmMesa_Load(object sender, EventArgs e)
        {

        }
    }
}
