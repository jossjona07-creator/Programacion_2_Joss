using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJEMPLO_1_SUMA_DE_DOS_NUMEROS_INGRESADOS
{
    public partial class suma_clase_joss : UserControl
    {
        public suma_clase_joss()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leemos los números de las cajas de texto por defecto
            int numero1 = Convert.ToInt32(textBox1.Text);
            int numero2 = Convert.ToInt32(textBox2.Text);

            // Los sumamos
            int suma = numero1 + numero2;

            // Mostramos el resultado en la etiqueta 3
            label3.Text = "Resultado: " + suma.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}