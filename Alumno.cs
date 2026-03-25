namespace TP0._5{

public class Alumno
{
    public string nombre;
    public double faltas;

    Dictionary<int, Alumno> dicAlumno = new Dictionary<int, Alumno>();

    public Alumno(int dni, string nombre)
    {
        this.nombre = nombre;
        this.faltas = 0;
    }

    foreach(int clave in dicAlumno.Keys)
    {
        Console.WriteLine(clave);
        Console.WriteLine(dicAlumnos[clave]);
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