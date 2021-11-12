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
using System.Collections;
using CapaControladorHoteleria;

namespace RecetasAreaHoteleria
{
    public partial class frmRecetaDetalle : Form
    {

        ClaseControlador co = new ClaseControlador();

        public frmRecetaDetalle()
        {
            InitializeComponent();
            co.LLenarTablaRecetaDetCo(dgvRecetaD);
            //funLlenarId();
            // funLlenarIdProducto(); 
            co.funLlenarComboReDeCo(cbxIdReceta);
            co.funLlenarComboProCo(cbxProducto);
             TextBox[] arreglo = { txtId, txtProducto,txtDescripcion };

            txtId.Enabled=false;
            txtProducto.Enabled = false;

        }

        private void frmRecetaDetalle_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_MouseClick(object sender, MouseEventArgs e)
        {
            insertar();
        }
        /*Geovani Fernando Mendoza Galiano 9959-18-15407*/
        public void insertar()
        {
            co.insertarCo(cbxIdReceta, cbxProducto,txtDescripcion, dgvRecetaD);
        }

        private void cbxIdReceta_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        //llenar txt
        public void funSeleccionarDTD(DataGridView data)
        {
            var filaSeleccionada = data.CurrentRow;
            int i = 0;
            TextBox[] arreglo = { txtId, txtProducto,txtDescripcion };
            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                {
                    arreglo[i].Text = celda.Value.ToString();
                    i++;
                }

            }
        }
       

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            insertar();
        }

        private void dgvRecetaD_SelectionChanged(object sender, EventArgs e)
        {
            funSeleccionarDTD(dgvRecetaD);
        }

        private void btnModificar_MouseClick(object sender, MouseEventArgs e)
        {
            co.modificarCo(txtDescripcion, txtId, txtProducto, dgvRecetaD);
        }

        private void btnEliminar_MouseClick(object sender, MouseEventArgs e)
        {
            co.EliminarCo(txtDescripcion,txtId,txtProducto,dgvRecetaD);
        }
    }
    
}
