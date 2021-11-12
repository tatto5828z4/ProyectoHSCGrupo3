using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloHoteleria;

namespace CapaControladorHoteleria
{
    public class ClaseControlador
    {
        ClaseModelo mo = new ClaseModelo();
        public string idPedido;


        /*Funcion para agregar los salones - 9959-18-4829 Josue Zapata*/
        public void dibujandoSalonesControlador(FlowLayoutPanel flow, TextBox stringBuscar, Panel bienvenida, FlowLayoutPanel mesas)
        {
            mo.dibujandoSalones(flow,stringBuscar,bienvenida,mesas);
        }

        public void dibujarProductosControlador(FlowLayoutPanel flowProductos, Panel da,Panel fe,DataGridView data,Label total)
        {
            mo.dibujarProductos(flowProductos,da,fe,data,total);
        }

        public string mostrarBusqueda(string id)
        {
            string idEnc = mo.buscarEncabezado(id);

            return idEnc;
        }

        public DataTable llenarTbl(string id,Label lbl)
        {
            return mo.llenarTbl(id,lbl);
        }

        public void funLlenarComboControl(ComboBox cbx)
        {
            mo.funLlenarCombo(cbx);
        }

        public void actualizarTotalControlador(string total,string id)
        {
            mo.ActualizarTotal(total,id);
        }

        public void totalActividad(string id, Label lbltotal)
        {
            mo.obtenerTotalActividad(id, lbltotal);
        }

        public void eliminarDet(DataGridView data, string id)
        {
            mo.eliminarDet(data,id);
        }

        /*Receta*/
        public void LLenarTablaControlador(DataGridView dvg)
        {
            mo.LLenarTabla(dvg);
        }

        public void insertarRecetaEncCon(TextBox id, TextBox nombre, TextBox preparacion, TextBox estado, DataGridView dvg)
        {
            mo.insertarRecetaEnc(id,nombre,preparacion,estado,dvg);
        }

        public void modificaRecetaEncCo(TextBox id, TextBox nombre, TextBox preparacion, TextBox estado, DataGridView dvg)
        {
            mo.modificaRecetaEnc(id,nombre,preparacion,estado,dvg);
        }

        public void buscarTxtCo(DataGridView data, TextBox id, TextBox nombre, TextBox preparacion, TextBox estado, TextBox buscar)
        {
            mo.buscarTxt(data, id, nombre, preparacion, estado, buscar);
        }

        /*Receta Det*/
        public void funLlenarComboReDeCo(ComboBox cbx)
        {
            mo.funLlenarComboReDe(cbx);
        }

        public void LLenarTablaRecetaDetCo(DataGridView data)
        {
            mo.LLenarTablaRecetaDet(data);
        }

        public void funLlenarComboProCo(ComboBox cbx)
        {
            mo.funLlenarComboPro(cbx);
        }

        public void insertarCo(ComboBox cbxID, ComboBox cbxPro, TextBox desc, DataGridView data)
        {
            mo.insertar(cbxID, cbxPro, desc, data);
        }

        public void modificarCo(TextBox desc, TextBox idEnc, TextBox codigoP, DataGridView data)
        {
            mo.modificar(desc, idEnc, codigoP, data);
        }

        public void EliminarCo(TextBox desc, TextBox idEnc, TextBox codigoP, DataGridView data)
        {
            mo.Eliminar(desc,idEnc,codigoP,data);
        }
    }
}
