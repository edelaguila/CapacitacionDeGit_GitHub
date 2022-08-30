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

        

        void insertarEmpleado()
        {
            string nombre, puesto, departamento;
            nombre = Txt_nombre.Text;
            puesto = Txt_puesto.Text;
            departamento = Txt_depto.Text;

            

            string cadena = "INSERT INTO empleados (nombre_completo, puesto, departamento) VALUES('"+nombre+"','"+puesto+"','"+departamento+"');" ;
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            insertarEmpleado();
            Txt_nombre.Text = "";
            Txt_depto.Text = "";
            Txt_puesto.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Consulta b = new Consulta();
            b.Show();
            this.Hide();
        }
    }
}
