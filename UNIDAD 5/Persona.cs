using System;

// Clase base Persona
public class Persona
{
    private int añoNacimiento;

    public int AñoNacimiento
    {
        get { return añoNacimiento; }
        set
        {
            if (value > 1900 && value <= DateTime.Now.Year)
                añoNacimiento = value;
            else
                throw new ArgumentException("Año de nacimiento inválido");
        }
    }

    public string Nombre { get; set; }
}

// Clase derivada Estudiante que hereda de Persona
public class Estudiante : Persona
{
    // Atributo calculado para la edad usando DateTime.Now
    public int EdadCalculada => DateTime.Now.Year - AñoNacimiento;
}