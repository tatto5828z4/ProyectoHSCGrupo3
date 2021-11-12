using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaControladorHoteleria;


namespace RecetasAreaHoteleria
{
    public partial class frmRecetaEncabezado : Form
    {

       
        ClaseControlador co = new ClaseControlador();
        //TextBox[] arreglo;
       

        public frmRecetaEncabezado()
        {
            InitializeComponent();
            co.LLenarTablaControlador(dgvRecetaE);
            TextBox[] arreglo = { txtIdReceta, txtNombre, txtPreparacion, txtEstado };

        }

        private void frmRecetaEncabezado_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            co.modificaRecetaEncCo(txtIdReceta, txtNombre, txtPreparacion, txtEstado, dgvRecetaE);

        }


        private void btnEliminar_MouseClick(object sender, MouseEventArgs e)
        {
        }

        //llenar txt
        public void funSeleccionarDT(DataGridView data)
        {
            var filaSeleccionada = data.CurrentRow;
            int i = 0;
            TextBox[] arreglo = { txtIdReceta, txtNombre, txtPreparacion, txtEstado };
            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                {
                    arreglo[i].Text = celda.Value.ToString();
                    i++;
                }

            }
        }

        private void dgvRecetaE_SelectionChanged(object sender, EventArgs e)
        {
           
           funSeleccionarDT(dgvRecetaE);
        }

        private void btnBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            co.buscarTxtCo(dgvRecetaE, txtIdReceta, txtNombre, txtPreparacion, txtEstado, txtBuscar);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            co.insertarRecetaEncCon(txtIdReceta, txtNombre, txtPreparacion, txtEstado, dgvRecetaE);
        }
    }
}
