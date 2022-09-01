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

        conexion cn = new conexion();

        void insertarEmpleado()
        {


            //cadena a insertar

            string cadena = "INSERT INTO empleados (nombre_completo, puesto, departamento) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"');";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conectar());
            consulta.ExecuteNonQuery();


        }



        private void Form1_Load(object sender, EventArgs e)
        {

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
            consulta b = new consulta();
            b.Show();
            this.Hide();
        }
    }
}
