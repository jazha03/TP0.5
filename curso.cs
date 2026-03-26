namespace TP0._5
{
public class Curso 
{
   Dictionary<int, Alumno> dicAlumno = new Dictionary<int, Alumno>();

    public bool AgregarAlumno(int dni, string nombre)
        {
            if (dicAlumno.ContainsKey(dni))
                return false;

            dicAlumno.Add(dni, new Alumno(dni, nombre));
            return true;
        }

    public Alumno BuscarAlumno(int dni)
        {
            if (dicAlumno.ContainsKey(dni))
                return dicAlumno[dni];

            return null;
        }

    public void MostrarAlumnos()
        {
            foreach (var item in dicAlumno.Values)
            {
                item.MostrarInfo();
            }
        }

    public void MostrarAlumnosLibres()
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

