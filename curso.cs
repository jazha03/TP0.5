namespace TP0._5
{
public class Curso 
{
   Dictionary<int, Alumno> dicAlumno = new Dictionary<int, Alumno>();

    public void agregarAlumno(int dni, string nombre)
    {
        Alumno nuevoAlumno = new Alumno(dni, nombre);
        dicAlumno.Add(dni, nuevoAlumno);
    }

   public Alumno buscarAlumno(int dni)
    {
        foreach (Alumno a in dicAlumno)
        {
            if (a.getDni() == dni)
            {
                return a;
            }
        }
        return null;
    }

     public void mostrarAlumnos()
    {
        foreach (Alumno a in dicAlumno)
        {
            a.mostrarInfo();
        }
        return a;
    }

    public void mostrarAlumnosLibres()
    {
        foreach (Alumno a in dicAlumno)
        {
            if (a.getFaltas() > 15)
            {
                a.mostrarInfo();
            }
        }
        return a;
    }
}
}

