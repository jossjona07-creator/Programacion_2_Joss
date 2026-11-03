using System.Collections.Generic;

public class ProductoService
{
    // Lista productos
    private List<Producto> productos;

    public ProductoService()
    {
        productos = new List<Producto>
        {
            new Producto { Nombre = "Laptop", Precio = 1200 },
            new Producto { Nombre = "Mouse", Precio = 25 },
            new Producto { Nombre = "Teclado", Precio = 50 }
        };
    }

    // obtener productos
    public List<Producto> ObtenerProductos()
    {
        return productos;
    }
}

// Clase Producto
public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
}