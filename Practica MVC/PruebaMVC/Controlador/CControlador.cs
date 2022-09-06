using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Modelo;

namespace Controlador
{
    public class CControlador
    {
        Sentencias sn = new Sentencias();

        public DataTable llenartbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenartbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        


    }
}
