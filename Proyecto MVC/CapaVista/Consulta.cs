using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Consulta : Form
    {
        String tabla = "empleados";
        Controlador cont = new Controlador();

        public Consulta()
        {
            InitializeComponent();
        }

        //Mostrar los datos CAPA VISTA


        public void actualizardatagriew()
        {
            DataTable dt = cont.llenarTbl(tabla);
            verdata.DataSource = dt;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
