namespace TP0._5{

public class Alumno
{
    public int dni;
    public string nombre;
    public double faltas;

    public Alumno(int dni, string nombre)
    {
        this.dni = dni;
        this.nombre = nombre;
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