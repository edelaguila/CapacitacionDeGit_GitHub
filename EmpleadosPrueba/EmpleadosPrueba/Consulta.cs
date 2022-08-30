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
    public partial class Consulta : Form
    {
        Conexion cn = new Conexion();
        public Consulta()
        {
            InitializeComponent();
        }

        void cargar()
        {
            string cadena = "SELECT * FROM empleados";
            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());

            DataTable dt = new DataTable();

            datos.Fill(dt);

            Dgb_1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
