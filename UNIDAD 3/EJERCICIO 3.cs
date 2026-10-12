using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIDAD_3
{
    public partial class EJERCICIO_3 : Form
    {
        public EJERCICIO_3()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int opcion = int.Parse(txtOpcion.Text);

            switch (opcion)
            {
                case 1:
                    MessageBox.Show("ELIGIÓ LA OPCIÓN 1");
                    break;
                case 2:
                    MessageBox.Show("ELIGIÓ LA OPCIÓN 2");
                    break;
                case 3:
                    MessageBox.Show("ELIGIÓ LA OPCIÓN 3");
                    break;
                default:
                    MessageBox.Show("Opción no válida");
                    break;
            }
        }
    }
}
