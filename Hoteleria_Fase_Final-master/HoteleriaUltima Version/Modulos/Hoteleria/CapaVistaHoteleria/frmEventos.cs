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
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();

            //Inicializacion
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "actividadReservacion", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //combobox
            navegador1.funLlenarComboControl(cbxCliente, "cliente", "Pkid", "nombre", "estatus");
            navegador1.funLlenarComboControl(cbxidSalon, "salon", "idSalon", "nombre", "estatus");

            //campo estado
            navegador1.campoEstado = "estatus";

            //ayuda 
            navegador1.idAplicacion = "1016";

            //ejecucion de ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";

            //asociacion con reporte
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");

            //tabla datagridview
            navegador1.pideGrid(this.dataGridView1);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);

            // Permisos
            navegador1.usuario = nombreUsuario.nombre;
            navegador1.aplicacion = "Mantenimiento Habitación";
            navegador1.funActualizarPermisos();

            navegador1.idmodulo = "1001";

            //ocultar botones
            txtCliente.Visible = false;
            txtSalon.Visible = false;
            txtEstado.Visible = false;

        }

        private void cbxNombre_SelectedValueChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxCliente, txtCliente);
        }

        private void cbxidSalon_SelectedValueChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxidSalon, txtSalon);
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxCliente, txtCliente);
        }

        private void txtSalon_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxidSalon, txtSalon); ;
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, radioButton1, "A");
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, radioButton2, "B");
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(radioButton1, radioButton2, txtEstado);
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dataGridView1);
        }
    }
}
