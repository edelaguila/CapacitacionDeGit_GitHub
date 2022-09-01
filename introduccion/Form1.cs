using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introduccion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        bool isNonEmpty(TextBox txt1, TextBox txt2, TextBox txt3)
        {
            bool isNonEmpty = false;
            isNonEmpty = String.IsNullOrEmpty(txt1.Text) == true | String.IsNullOrEmpty(txt2.Text) == true | String.IsNullOrEmpty(txt3.Text) == true ? true : false;
            return isNonEmpty;
        }
        Conexion cn = new Conexion(); 

        void insertarEmpleado()
        {
            if (isNonEmpty(txt_nombre, txt_marca, txt_existencia)==false)
            {
                string estado = rdb_activo.Checked == true ? "1" : "0";
                string cadena = "INSERT INTO productos (nombre_producto,marca_producto,existencia_producto,estatus_producto)  VALUES ('" + txt_nombre.Text + "', '" + txt_marca.Text + "', '" + txt_existencia.Text + "', '" + estado + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            insertarEmpleado();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string cadena = "SELECT * FROM productos;";
            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());
            DataTable dt = new DataTable();
            datos.Fill(dt);
            dtv_datos.DataSource = dt;
        }
    }
}
