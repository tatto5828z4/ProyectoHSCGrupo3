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
    public partial class frmTipoCliente : Form
    {
        public frmTipoCliente()
        {
            InitializeComponent();


            //Inicializacion
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "tipoCliente", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //Dar de baja 
            navegador1.campoEstado = "estatus";

            //ayuda 
            navegador1.idAplicacion = "1004";

            //ejecucion de ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";

            //asociacion con reporte
            navegador1.funReportesVista("ruta", "idAplicacion", "reporte");

            //tabla Data grid view
            navegador1.pideGrid(dgvTipoCliente);
            navegador1.llenaTabla();

            //referencia a la forma para que el navegador pueda cerrarla
            navegador1.pedirRef(this);

            // Permisos
            navegador1.usuario = nombreUsuario.nombre;
            navegador1.aplicacion = "Mantenimiento Tipo Cliente";
            navegador1.funActualizarPermisos();

            navegador1.idmodulo = "1001";

            //ocultando txt de apoyo 
            txtEstatus.Visible = false;


            //ocultando txt de apoyo 
            txtEstatus.Visible = false;

        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, rbtActivo, "A");
        }

        private void frmTipoCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void rbtInactivo_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, rbtInactivo, "I");
        }

        private void txtEstatus_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rbtActivo, rbtInactivo, txtEstatus);
        }

        private void dgvTipoCliente_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dgvTipoCliente);
        }
    }
}
