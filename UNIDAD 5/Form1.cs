using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIDAD_5
{
    public partial class Form1 : Form
    {
        private ProductoService productoService;

        public Form1()
        {
            InitializeComponent();
            productoService = new ProductoService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productoService.ObtenerProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCargar_Click(sender, e);
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            // Ejercicio 2
            Estudiante est = new Estudiante();
            est.Nombre = "Ana";
            est.AñoNacimiento = 2000;

            MessageBox.Show($"Nombre: {est.Nombre}, Edad calculada: {est.EdadCalculada}");
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            // Ejercicio 3
            List<Producto> listaProductos = new List<Producto>
            {
                new Producto { Nombre = "Laptop", Precio = 1200 },
                new Producto { Nombre = "Mouse", Precio = 25 },
                new Producto { Nombre = "Teclado", Precio = 50 }
            };

            DialogResult result = MessageBox.Show(
                "¿Desea continuar?",
                "Confirmar",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Continuando el proceso...");

                foreach (var p in listaProductos)
                {
                    MessageBox.Show($"Producto: {p.Nombre} - Precio: {p.Precio:C}");
                }
            }
            else
            {
                MessageBox.Show("Proceso cancelado.");
            }
        }
    }
}