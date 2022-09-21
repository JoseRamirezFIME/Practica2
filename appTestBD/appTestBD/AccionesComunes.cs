using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace appTestBD
{
    internal class AccionesComunes
    {
        public static void Mensaje(String mensaje) {
            MessageBox.Show(mensaje, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void LlenarCombo(String consulta, ComboBox combo, string id, string Nombres)
        {
            combo.ValueMember = id;
            combo.DisplayMember = Nombres;
            DataTable dt = new DataTable();
            dt = Conexion.EjecutaSeleccion(consulta);
            dt.Rows.Add(0, "Todos");
            if (dt == null)
            {
                return;
            }
           combo.Items.Clear();
            combo.DataSource = dt;
        }


    }
}
