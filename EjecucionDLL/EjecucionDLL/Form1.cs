using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//cesar Armando Estrada Elias 0901-22-10153
namespace EjecucionDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargardatos();
        }
        //Ejecución//
        void cargardatos()
        {



            combo1.llenarse("empleados", "puesto", "nombre_completo");


        }
    }
}
