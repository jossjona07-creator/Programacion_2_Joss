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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int opcion = int.Parse(txtOpcion.Text);

            switch (opcion)
            {
                case 1:
                    MessageBox.Show("Elegiste opción 1");
                    break;
                case 2:
                    MessageBox.Show("Elegiste opción 2");
                    break;
                case 3:
                    MessageBox.Show("Elegiste opción 3");
                    break;
                default:
                    MessageBox.Show("Opción no válida");
                    break;
            }
        }
    }
}