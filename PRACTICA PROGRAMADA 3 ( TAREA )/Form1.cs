using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_PROGRAMADA_3___TAREA__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            int dia;

            // Veo que sea un número entero válido
            if (int.TryParse(txtDia.Text, out dia))
            {
                switch (dia)
                {
                    case 1:
                        MessageBox.Show("Lunes", "Día de la semana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        MessageBox.Show("Martes", "Día de la semana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        MessageBox.Show("Miércoles", "Día de la semana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 4:
                        MessageBox.Show("Jueves", "Día de la semana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 5:
                        MessageBox.Show("Viernes", "Día de la semana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 6:
                        MessageBox.Show("Sábado", "Día de la semana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 7:
                        MessageBox.Show("Domingo", "Día de la semana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        MessageBox.Show("Error: El número ingresado debe estar entre 1 y 7.", "Valor fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error: Debe ingresar un número entero válido.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Realmente desea salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                // cancela el cierre y sigue ejecutándose
                e.Cancel = true;
            }
        }
    }
}