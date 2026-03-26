namespace TP0._5;

public class Program 
{       
    static void Main(string[] args)
    {

        Curso curso = new Curso();
        int opcion;
        do
        {
            Console.WriteLine("1. Agregar Alumno");
            Console.WriteLine("2. Buscar alumno con DNI");
            Console.WriteLine("3. Agregar falta");
            Console.WriteLine("4. Mostrar alumnos");
            Console.WriteLine("5. Mostrar alumnos libres");
            Console.WriteLine("6. Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    agregarAlumno(curso);
                    break;

                case 2:
                    buscarAlumno(curso);
                    break;

                case 3:
                    agregarFalta(curso);
                    break;

                case 4:
                    mostrarAlumnos(curso);
                    break;

                case 5:
                    mostrarAlumnosLibres(curso);
                    break;
                case 6:
                break;

            }

        } while (opcion != 0);
       
       static void agregarAlumno(Curso curso)
        {
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            if (curso.AgregarAlumno(dni, nombre))
            {
                Console.WriteLine("Alumno agregado");
            }
            else
            {
               Console.WriteLine("Ya existe");
            }
        }

        static void buscarAlumno(Curso curso)
        {
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());
            Alumno a = curso.buscarAlumno(dni);
            if (a != null)
            {
                a.MostrarInfo();
            }
            else
            {
                Console.WriteLine("No encontrado");
            }
        }


        static void agregarFalta(Curso curso)
        {
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());

            Alumno a = curso.buscarAlumno(dni);

            if (a != null)
            {
                Console.Write("1.Falta completa  2.Media falta: ");
                int tipo = int.Parse(Console.ReadLine());

                if (tipo == 1)
                {
                    a.AgregarFalta(1);
                }
                else
                {
                    a.AgregarFalta(0.5);
                }
            }
            else
            {
                Console.WriteLine("Alumno no encontrado");
            }
        }

    }
}