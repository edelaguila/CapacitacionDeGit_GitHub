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
//cesar Armando Estrada Elias 0901-22-10153

namespace CapaVista
{
    public partial class combo : UserControl
    {
        public combo()
        {
            InitializeComponent();
        }
        ///Vista///

        Controlador cn = new Controlador();

        public void llenarse(string tabla, string campo1, string campo2)
        {

            string tbl = tabla;
            string cmp1 = campo1;
            string cmp2 = campo2;
          

           
            cmb_auto.ValueMember = "numero";
            cmb_auto.DisplayMember = "nombre";

            string[] items = cn.items(tabla, campo1, campo2);



            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        cmb_auto.Items.Add(items[i]);
                    }
                }

            }

            var dt2 = cn.enviar(tabla, campo1, campo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));


            }

            cmb_auto.AutoCompleteCustomSource = coleccion;
            cmb_auto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_auto.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }
    }
}
