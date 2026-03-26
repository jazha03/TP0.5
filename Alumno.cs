namespace TP0._5{

public class Alumno
{
    public string nombre;
    public int dni;
    public double faltas;

    public Alumno(int dni, string nombre)
    {
        this.nombre = nombre;
        this.dni = dni;
        this.faltas = 0;
    }

    public void mostrarInfo()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("DNI: " + dni);
        Console.WriteLine("Faltas: " + faltas);
    }

    public void agregarFalta(double cantidad)
    {
        this.faltas += cantidad;
    }

    public int getDni()
    {
        return this.dni;
    }
    
    public double getFaltas()
    {
        return this.faltas;
    }
}
}