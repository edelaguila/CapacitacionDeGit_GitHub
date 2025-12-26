using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//// librerias//// 
using System.Data;
using CapaModelo;
using System.Data.Odbc;
//cesar Armando Estrada Elias 0901-22-10153
namespace CapaControlador
{
    public class Controlador
    {

        ///Controlador///

        Sentencias sn = new Sentencias();

        public string[] items(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmb(tabla, campo1, campo2);

            return Items;


        }

        ///Controlador 2///

        public DataTable enviar(string tabla, string campo1, string campo2)
        {



            var dt1 = sn.obtener(tabla, campo1, campo2);

            return dt1;
        }
    }
}
