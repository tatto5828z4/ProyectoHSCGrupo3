using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
    public class ctlEnlaceContableHoteleria_impuesto
    {

        Sentencias sn = new Sentencias();

        public string calculoDebe(string fechaInicio, string fechaFinal)
        {
            string total = sn.calculoDebe(fechaInicio, fechaFinal);
            return total;
        }
        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public string calculoHaber(string fechaInicio, string fechaFinal)
        {
            string total = sn.calculoHaber(fechaInicio, fechaFinal);
            return total;
        }

        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        //Insertar encabezado
        public void insertarEncabezado(string id, string fecha, string tipoPoliza)
        {
            sn.insertarEncabezado(id, fecha, tipoPoliza);

        }

        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public string incrementarId()
        {
            string id = sn.incrementarId();

            return id;
        }

        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public void insertarDetalle(string Id, string fecha, string idCuenta, string saldo, string idtipoOp, string concepto)
        {
            sn.insertarDetalle(Id, fecha, idCuenta, saldo, idtipoOp, concepto);
        }

        public void consultaSaldo(string fechaI,string fechaF)
        {
            sn.ConsultaSaldos(fechaI, fechaF);
        }
    }

}
