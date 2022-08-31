using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace EmpleadosPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Instanciamos un elemento para llamar a nuestra conexion
        Conexion cn = new Conexion();
        void insertarEmpleado()
        {
            string cadena = "INSERT INTO empleados (codigo_empleado,nombre_completo,puesto,departamento,estado) VALUES ('" + int.Parse(txt_codigo.Text) + "','" + txt_nombre.Text + "','" + txt_puesto.Text + "','" + txt_depto.Text + "','" + int.Parse(txt_estado.Text) + "');";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            insertarEmpleado();
            txt_codigo.Text = "";
            txt_depto.Text = "";
            txt_nombre.Text = "";
            txt_puesto.Text = "";
            txt_estado.Text = "";
        }
    }
}
