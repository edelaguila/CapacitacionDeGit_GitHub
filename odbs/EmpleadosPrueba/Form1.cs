﻿using System;
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
        void insertarempleado()
        {

            string cadena = "INSERT INTO empleados (nombre_completo, puesto, departamento) VALUES('" + txt_nombre.Text + "', '" + txt_puesto.Text + "', '"+ txt_depto.Text + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertarempleado();
            txt_depto.Text = "";
            txt_puesto.Text = "";
            txt_nombre.Text = "";
        }

    }

}

