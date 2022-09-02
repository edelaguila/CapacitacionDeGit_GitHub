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

namespace EmpleadosPrueba
{
    public partial class Form2 : Form
    {
        Conexion cn = new Conexion();
        public Form2()
        {
            InitializeComponent();
        }

        void cargar()
        {
            string cadena = "SELECT * FROM empleados";
            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());

            DataTable dt = new DataTable();

            datos.Fill(dt);

            dataGridView1.DataSource = dt;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
