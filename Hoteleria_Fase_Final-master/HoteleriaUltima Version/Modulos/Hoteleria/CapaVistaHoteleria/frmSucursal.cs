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
    public partial class frmSucursal : Form
    {

        public frmSucursal()
        {
            InitializeComponent();

            //Inicializacion
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "sucursal", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //combobox
            navegador1.funLlenarComboControl(cbxEmpresa, "empresa", "idEmpresa", "nombre", "estatus");

            //campo estado
            navegador1.campoEstado = "estatus";

            //ayuda 
            navegador1.idAplicacion = "1003";

            //ejecucion de ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";

            //asociacion con reporte
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");

            //tabla datagridview
            navegador1.pideGrid(this.dgvSucursal);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);

            // Permisos
            navegador1.usuario = nombreUsuario.nombre;
            navegador1.aplicacion = "Mantenimiento Sucursal";
            navegador1.funActualizarPermisos();

            navegador1.idmodulo = "1001";


            //ocultar botones
            txtIdEmpresa.Visible = false;
            txtEstatus.Visible = false;
        }


        private void frmSucursal_Load(object sender, EventArgs e)
        {
               
        }

        private void cbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cbxEmpresa, txtIdEmpresa);
        }

        private void txtIdEmpresa_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxEmpresa, txtIdEmpresa);
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

        private void dgvSucursal_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dgvSucursal);
        }
    }
}
