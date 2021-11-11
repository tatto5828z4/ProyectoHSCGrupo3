using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using System.Data.Odbc;
using System.Collections;


namespace Controlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        //Hecho por Wilber Enrique Segura Ramirez 0901-18-13952
        /*public DataTable llenarTabla(string tabla)//Método Genérico para llenar datagrids
        {
            OdbcDataAdapter dt = sn.llenarTabla(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }*/
    }
}
