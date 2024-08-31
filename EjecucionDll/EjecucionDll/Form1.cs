using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjecucionDll
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



            combo1.llenarse("empleados", "codigo_empleado", "puesto");


        }


    }
}
