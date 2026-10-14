using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace UNIDAD_4
{
    public class Producto
    {
        // para el Nombre
        public string Nombre { get; set; }

        // respaldar el Precio
        private decimal precio;

        // Propiedad con get y set para validar que el precio sea mayor a 0
        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
                else
                {
                    MessageBox.Show("El precio debe ser mayor a 0.");
                }
            }
        }

        // mostrar la información
        public void MostrarInfo()
        {
            MessageBox.Show($"Producto: {Nombre}, Precio: ${precio}");
        }
    }
}