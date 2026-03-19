namespace TP0._5

public class Curso
 private int alum;
    private int alumDni;
    private string alumInfo;
    List<int> listAlum = new List<int>

    private bool agregarAlum(int dni, string nombre, double faltas)
    {
        Alumno i  = this.buscarAlumno(nombre)
        bool agregado = false;
        if (i == null){
            alumno nuevo = new alumno(dni, nombre, faltas);
            this.listAlum.Add(nuevo)
            agregado = true;
        }
        return agregado;
    }

    private Alumno buscarAlumno(int dni)
    {
        int i = 0;
        Alumno encontrado = null;
        while ( i < this.listAlum && !this.listAlum[i].esMismoDni(dni))
        {
            i++;
        }
        if (i <this.listAlum.Count)
        {
            encontrado = this.listAlum[i];
        }
        return encontrado;
    }

    private string mostrarAlumnos(string nombre, double faltas)
    {
       foreach (Alumno i in listAlum)
       {
        i.mostrarInfo();
       }
    }
