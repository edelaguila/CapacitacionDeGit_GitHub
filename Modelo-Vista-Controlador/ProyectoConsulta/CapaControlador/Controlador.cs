using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
/////////librerias////////
using System.Data;
using System.Data.Odbc;


namespace CapaControlador
{
    public class Controlador
    {
        Sentencia sn = new Sentencia();

        // LLenar una tabla CAPA CONTROLADOR


        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


    }
}
