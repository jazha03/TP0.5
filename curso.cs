namespace TP0._5
{
public class Curso 
{
   Dictionary<int, Alumno> dicAlumno = new Dictionary<int, Alumno>();

    public bool agregarAlumno(int dni, string nombre)
        {
            if (dicAlumno.ContainsKey(dni))
                return false;

            dicAlumno.Add(dni, new Alumno(dni, nombre));
            return true;
        }

    public Alumno buscarAlumno(int dni)
        {
            if (dicAlumno.ContainsKey(dni))
                return dicAlumno[dni];

            return null;
        }

    public void mostrarAlumnos()
        {
            foreach (var item in dicAlumno.Values)
            {
                item.MostrarInfo();
            }
        }

    public void mostrarAlumnosLibres()
        {
            foreach (var item in dicAlumno.Values)
            {
                if (item.GetFaltas() > 15)
                {
                    item.MostrarInfo();
                }
            }
        }
}
}

