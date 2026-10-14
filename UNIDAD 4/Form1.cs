using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIDAD_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto p1 = new Producto();

            // valores a las propiedades
            p1.Nombre = "Laptop";
            p1.Precio = 750.00m;

            // Llamar al método del objeto
            p1.MostrarInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear objeto de la clase Producto
            Producto p2 = new Producto();

            // Dar el nombre 
            p2.Nombre = txtNombre.Text;

            // Validar que el precio 
            if (decimal.TryParse(txtPrecio.Text, out decimal precioIngresado))
            {
                // Al dar el precio se activa la validación 'set' 
                p2.Precio = precioIngresado;

                // Si pasó la validación, mayor a 0, se muestra
                if (p2.Precio > 0)
                {
                    p2.MostrarInfo();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para el precio.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Limpiamos error anterior
            errorProvider1.Clear();

            bool hayError = false;
            decimal precioIngresado = 0; 

            // 1. Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre del producto es obligatorio.");
                hayError = true;
            }

            // 2. Validar que el precio no esté vacío sea un número válido y mayor a 0
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                errorProvider1.SetError(txtPrecio, "El precio es obligatorio.");
                hayError = true;
            }
            else if (!decimal.TryParse(txtPrecio.Text, out precioIngresado) || precioIngresado <= 0)
            {
                errorProvider1.SetError(txtPrecio, "El precio debe ser un número mayor a 0.");
                hayError = true;
            }

            // 3. Si pasa todo correctamente
            if (!hayError)
            {
                Producto p3 = new Producto();
                p3.Nombre = txtNombre.Text;
                p3.Precio = precioIngresado;

                MessageBox.Show("¡Validación exitosa con ErrorProvider!");
                p3.MostrarInfo();
            }
        }
    }
}