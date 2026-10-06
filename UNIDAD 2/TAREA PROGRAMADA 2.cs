using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIDAD_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //  ListBox 
            this.listBoxColores.SelectedIndexChanged += new System.EventHandler(this.listBoxColores_SelectedIndexChanged);
        }

        //  Cargar los colores en el ListBox 
        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxColores.Items.Add("Rojo");
            listBoxColores.Items.Add("Verde");
            listBoxColores.Items.Add("Azul");
        }

        //  Método del Botón IF / ELSE
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtNumero1.Text);
                int num2 = Convert.ToInt32(txtNumero2.Text);

                if (num1 > num2)
                {
                    MessageBox.Show("El número mayor es: " + num1, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (num2 > num1)
                {
                    MessageBox.Show("El número mayor es: " + num2, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ambos números son iguales.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese solo números válidos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // cambiar el fondo al hacer clic ListBox
        private void listBoxColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxColores.SelectedItem != null)
            {
                string colorSeleccionado = listBoxColores.SelectedItem.ToString();

                if (colorSeleccionado == "Rojo")
                {
                    this.BackColor = Color.LightCoral;
                }
                else if (colorSeleccionado == "Verde")
                {
                    this.BackColor = Color.LightGreen;
                }
                else if (colorSeleccionado == "Azul")
                {
                    this.BackColor = Color.LightBlue;
                }
            }
        }

        // menú contextual
        private void cambiarColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}