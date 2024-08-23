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
    public partial class Control : Form
    {
        Consulta consulta;
        public Control()
        {
            InitializeComponent();
            consulta = new Consulta();
        }
        Conexion cn = new Conexion();

        void insertarEmpleado()
        {
            string cadena = "INSERT INTO empleados (nombre_completo, puesto, departamento) VALUES ('" + txtNombre.Text + "', '" + txtPuesto.Text + "', '" + txtDepartamento.Text + "');";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());

            consulta.ExecuteNonQuery();

            MessageBox.Show("Se ingreso el nuevo empleado");
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            insertarEmpleado();

            txtNombre.Text = "";
            txtPuesto.Text = "";
            txtDepartamento.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consulta.ShowDialog();
        }
    }
    
}
