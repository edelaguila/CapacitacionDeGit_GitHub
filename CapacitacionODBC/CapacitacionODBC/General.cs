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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        void InsertarEmpleado()
        {
            //Cadena a insertar

            string Cadena = "INSERT INTO empleados (nombre_completo, puesto, departamento) VALUES ('" + Txt_nombre.Text + "','" + Txt_puesto.Text + "','" + Txt_departamento.Text + "');";
            OdbcCommand consulta = new OdbcCommand(Cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            InsertarEmpleado();
            Txt_departamento.Text = "";
            Txt_puesto.Text = "";
            Txt_nombre.Text = "";
        }

        private void Btn_consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consulta Consulta = new Consulta();
            Consulta.ShowDialog();
            this.Close();
        }
    }
}
