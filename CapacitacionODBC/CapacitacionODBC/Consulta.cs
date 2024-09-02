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

namespace CapacitacionODBC
{
    public partial class Consulta : Form
    {
        Conexion cn = new Conexion();

        public Consulta()
        {
            InitializeComponent();
            cargar();
        }

        void cargar()
        {
            string cadena = "SELECT * FROM empleados";

            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());

            DataTable dt = new DataTable();

            datos.Fill(dt);

            Dgv_consulta.DataSource = dt;
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            General General = new General();
            General.ShowDialog();
            this.Close();
        }
    }
}
