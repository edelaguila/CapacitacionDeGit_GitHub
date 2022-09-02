using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace EmpleadosPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Conexion cn = new Conexion();

        void insertarempleado()
        {
            String cadena = "INSERT INTO empleados (nombre_completo,puesto,departamento) VALUES (" + name.Text + "," + puesto.Text + ", " + depto.Text + ");";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarempleado();
            name.Text = "";
            puesto.Text = "";
            depto.Text = "";
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            Consulta cs = new Consulta();
            cs.Show();
            this.Hide();
        }
    }
}
