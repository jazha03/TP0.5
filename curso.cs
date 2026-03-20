namespace TP0._5
{
public class Curso 
{
    private List<Alumno> listaAlumnos = new List<Alumno>();

     public bool agregarAlumno(int dni, string nombre)
    {
        Alumno existente = buscarAlumno(dni);

        if (existente == null)
        {
            Alumno nuevo = new Alumno(dni, nombre);
            listaAlumnos.Add(nuevo);
            return true;
        }
        return false;
    }

   public Alumno buscarAlumno(int dni)
    {
        foreach (Alumno a in listaAlumnos)
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
        foreach (Alumno a in listaAlumnos)
        {
            a.mostrarInfo();
        }
    }

    public void mostrarAlumnosLibres()
    {
        foreach (Alumno a in listaAlumnos)
        {
            if (a.getFaltas() > 15)
            {
                a.mostrarInfo();
            }
        }
    }
}
}

