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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            // Formulario cargado correctamente
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botón Mostrar: Captura los datos de las tres cajas de texto y los muestra en pantalla
            string nombre = textBox1.Text;
            string cedula = textBox2.Text;
            string correo = textBox3.Text;

            MessageBox.Show("--- DATOS DEL USUARIO REGISTRADO ---\n\n" +
                            "Nombre: " + nombre + "\n" +
                            "Cédula: " + cedula + "\n" +
                            "Correo: " + correo,
                            "Registro Exitoso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Botón Limpiar: Borra el contenido de todas las cajas de texto y regresa el cursor al inicio
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Botón Salir: Cierra el formulario actual
            this.Close();
        }
    }
}