using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;

namespace Capa_Vista
{
    public partial class Consulta : Form
    {
        string emp = "empleados";
        Controlador cn = new Controlador();




        public Consulta()
        {
            InitializeComponent();
        }

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            Dtg1.DataSource = dt;

        }


        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void BtnCons_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
