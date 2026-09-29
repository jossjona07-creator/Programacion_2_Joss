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
    public partial class CLASE_MULTIPLICACION_JOSS : UserControl
    {
        public CLASE_MULTIPLICACION_JOSS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leemos los números decimales de las cajas de texto por defecto
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);

            // Multiplicamos los dos números
            double resultado = numero1 * numero2;

            // Mostramos el resultado en el label de abajo (label4)
            label4.Text = "Resultado: " + resultado.ToString();
        }
    }
}