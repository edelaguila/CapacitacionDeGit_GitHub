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
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
        }
        conexion cn = new conexion();

        void cargar()
        {

            string cadena = "SELECT * FROM empleados";

            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conectar());

            DataTable dt = new DataTable();

            datos.Fill(dt);
            dataGridView1.DataSource = dt;

        }



        private void consulta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
