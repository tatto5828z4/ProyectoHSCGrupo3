using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data;
using System.Threading.Tasks;

namespace CapaModeloMBancos
{
    public class Conexion
    {
        public OdbcConnection conexion()//Luis Reyes 0901-15-3121
        {
            //creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=conexionHSC");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se establecio Conexion!");
            }
            return conn;
        }

        //metodo para cerrar la conexion
        public void desconexion(OdbcConnection conn)//Luis Reyes 0901-15-3121
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se establecio Conexion!");
            }
        }
    }
}


