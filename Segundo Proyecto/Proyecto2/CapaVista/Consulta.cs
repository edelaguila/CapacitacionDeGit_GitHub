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
        string emp = "emplados";
        Controlador cn = new Controlador();





        public Consulta()
        {
            InitializeComponent();
        }


        //Mostrar los datos CAPA VISTA
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            Dgv_registros.DataSource = dt;

        }


        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
            



        }
    }
}
