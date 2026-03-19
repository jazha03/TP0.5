namespace TP0._5;

class Program
{       
       List<string> list = new List<string> {"Agregar Alumno", "Buscar alumno con DNI", "Agregar falta", "Mostrar a los alumnos",  "Mostrar alumnos con + de 15 faltas"}
       Menu menu = new Menu();

       int opcion;
       do 
       {
        Console.Clear();
        opcion = menu.pedirOpcion(list.Count);
        switch(opcion)
        {
            case 1:
            agregarAlum(curso)
            break;

            case 2:
            buscarAlumno(curso)
            break;
        }

       }

}

static void buscarAlumno(curso curso)
{
    
}

static void agregarAlum (Curso Curso)
{
    int dni = ingresarNumero("DNI: ");
    string nombre = ingresarTexto("Nombre: ");
    double faltas = ingresarDouble("Faltas: ")

    if(curso.agregarAlum(dni, nombre, faltas))
    {
        Console.WriteLine("Se agregó el alumno.")
    }
    else
    {
        Console.WriteLine("Ya existe un alumno con ese nombre.")
    }

}





static string ingresarTexto(string mensaje)
{
    string texto = "";
    while (texto == "")
    {
        Console.WriteLine(Mensaje);
        texto = Console.ReadLine();
    }
    return texto;
}

static int ingresarNumero(string mensaje)
{
    int num = 0;
    bool pude;
    do
    {
        Console.WriteLine(mensaje);
        pude = int.TryParse(Console.ReadLine(), out num);
        if (!pude)
            Console.WriteLine("Ingresá un número");
    }
    while (!pude);
    return num;
}

static int ingresarDouble(string mensaje)
{
    double num = 0;
    bool pude;
    do
    {
        Console.WriteLine(mensaje);
        pude = double.TryParse(Console.ReadLine(), out num);
        if (!pude)
            Console.WriteLine("Ingresá un número");
    }
    while (!pude);
    return num;
}