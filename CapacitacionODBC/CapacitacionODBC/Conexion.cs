using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionODBC
{
    class Conexion
    {
        public OdbcConnection conexion()
        {
            //creacion de la conexion ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=Prueba1");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("Conexión fallida");
            }
            return conn;
        }

        //Método para cerrar la conexión
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("Conexión fallida");
            }
        }
    }
}
