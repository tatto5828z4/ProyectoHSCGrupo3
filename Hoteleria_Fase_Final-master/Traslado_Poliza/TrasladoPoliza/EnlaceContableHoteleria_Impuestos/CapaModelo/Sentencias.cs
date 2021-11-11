using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{

    public class Sentencias
    {
        Conexion cn = new Conexion();


        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public string calculoDebe(string fechaI, string fechaF)
        {
            //select sum(saldo) from polizaDetalle where concepto = 'Venta' and idTipoOperacion = '1' 
            //and fechaPoliza between cast('2021-10-1' as date) and cast('2021-10-02' as date);

            string total = "";
            string Query = "select sum(saldo) from polizaDetalle where concepto = 'impuesto' and idTipoOperacion = '1' and" +
                " fechaPoliza between cast('" + fechaI + "' as date) and cast('" + fechaF + "' as date) ;";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                total = busqueda["sum(saldo)"].ToString();

            }

            return total;
        }

        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public string calculoHaber(string fechaI, string fechaF)
        {
            

            string total = "";
            string Query = "select sum(saldo) from polizaDetalle where concepto = 'impuesto' and idTipoOperacion = '2' and" +
                " fechaPoliza between cast('" + fechaI + "' as date) and cast('" + fechaF + "' as date) ;";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                total = busqueda["sum(saldo)"].ToString();

            }

            return total;
        }

        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public string incrementarId()
        {
            string id = "";
           
            string Query = " SELECT(idPolizaEncabezado * 1) as `idPolizaEncabezado` from polizaEncabezado order by(idPolizaEncabezado) DESC limit 1;";
            

                OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
                consulta.ExecuteNonQuery();

                OdbcDataReader busqueda;
                busqueda = consulta.ExecuteReader();
                string verifica = "1";

                if (busqueda.Read() )
                {

                    id = busqueda["idPolizaEncabezado"].ToString();

                }


                else
                {
                    Console.WriteLine("Error acá");
                }
                return id;
          
        }

        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public void insertarEncabezado(string Id, string fecha, string tipoPoliza)
        {
            string cadena = "INSERT INTO" +
            " polizaEncabezado VALUES (" + "'" + Id + "', '" + fecha + "' ,'" + tipoPoliza + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }


        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public void insertarDetalle(string Id, string fecha, string idCuenta, string saldo, string idtipoOp, string concepto)
        {


            string cadena = "INSERT INTO" +
            " polizaDetalle VALUES (" + "'" + Id + "', '" + fecha + "' ,'" + idCuenta + "','" + saldo + "','" + idtipoOp + "','" + concepto + "' );";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }


        /*Geovani Fernando Mendoza Galiano  9959-18-15407*/
        public void ConsultaSaldos(string fechaI, string fechaF)
        {

            string total = "";

            string Query = " SELECT * FROM polizaDetalle WHERE fechaPoliza BETWEEN '" + fechaI  + "' AND '"  + fechaF +" '" ;


            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

           
        }


    }
}
