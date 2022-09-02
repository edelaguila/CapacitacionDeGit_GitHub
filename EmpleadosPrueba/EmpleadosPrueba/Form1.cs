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
            nombre = textBox1.Text;
            puesto = textBox2.Text;
            departamento = textBox3.Text;

            //cadena a insertar

            string cadena = "INSERT INTO empleados (nombre_completo, puesto, departamento) VALUES('" + nombre + "','" + puesto + "','" + departamento + "');";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertarEmpleado();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 b = new Form2();
            b.Show();
            this.Hide();
        }
    }
}
