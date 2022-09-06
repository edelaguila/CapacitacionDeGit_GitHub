using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Modelo
{
     class Conexion
    {
        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=PracticaODBC");
            try
            {
                conn.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            return conn;
        }

        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

    }
}
