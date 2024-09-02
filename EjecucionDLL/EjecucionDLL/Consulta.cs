using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjecucionDLL
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
            cargardatos();
        }

        void cargardatos()
        {
            combo1.llenarse("empleados", "codigo_empleado", "puesto");
        }
    }
}
