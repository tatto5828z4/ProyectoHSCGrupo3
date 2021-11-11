using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;



namespace Modelo
{
    class Conexion
    {
        public OdbcConnection conexion()//Hecho por Wilber Enrique Segura Ramirez 0901-18-13952
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
        public void desconexion(OdbcConnection conn)//Hecho por Wilber Enrique Segura Ramirez 0901-18-13952
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
