namespace TP0._5

Public class Alumno{}
{
    public int dni;
    public string nombre;
    public double faltas;

    public void mostrarInfo()
    {
        Console.WriteLine("Nombre: " + this.nombre);
        Console.WriteLine("DNI: " + this.dni);
        Console.WriteLine("Faltas: "+ this.faltas);
    }
}
