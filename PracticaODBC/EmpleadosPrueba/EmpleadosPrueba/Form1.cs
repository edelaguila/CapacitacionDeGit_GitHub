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

        Conexion cn = new Conexion();

        //Funcion para insertar------------

        void insertarEmpleado()
        {

            //cadena a insertar

            string cadena = "INSERT INTO empleados(nombre_completo, puesto, departamento) VALUES ('" + txtnombre + "', '" + txtpuesto + "','" + txtdept + "')";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            insertarEmpleado();
            txtnombre.Text = "";
            txtpuesto.Text = "";
            txtdept.Text = "";
        }
    }
}
