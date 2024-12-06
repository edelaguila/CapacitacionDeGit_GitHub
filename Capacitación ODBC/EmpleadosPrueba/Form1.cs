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
    public partial class txt_depto : Form
    {
        public txt_depto()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        // Función para insertar
        void insertarEmpleado()
        {
            // Cadena a insertar con manejo adecuado de variables de texto
            string cadena = "INSERT INTO empleados (nombre_completo, puesto, departamento) " +
                            "values ('" + txt_nombre.Text + "', '" + txt_puesto.Text + "', '" + textBox3.Text + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());

            try
            {
                consulta.ExecuteNonQuery();
                MessageBox.Show("Empleado insertado correctamente.");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al insertar el empleado: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión después de la operación
                cn.desconexion(consulta.Connection);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar código de inicialización si es necesario
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Evento de clic para label4 si se requiere alguna acción
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            insertarEmpleado();
            textBox3.Text = "";
            txt_puesto.Text = "";
            txt_nombre.Text = "";
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Consulta
            Consulta consultaForm = new Consulta();

            // Mostrar el formulario Consulta
            consultaForm.Show();
        }
    }
}
