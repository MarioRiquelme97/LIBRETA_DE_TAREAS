

List<string> list = new List<string>();
string AUXI = string.Empty;


while (AUXI != "no")
{
    Console.WriteLine("Quieres agregar tarea?");
    string AFIRMACION = Console.ReadLine();
    AUXI = AFIRMACION;


    switch (AFIRMACION)
    {
        case "si":
            Console.WriteLine("Escribe tarea");
            string tarea = Console.ReadLine();
            list.Add(tarea);
            Console.Clear();
            Console.WriteLine("TAREAS INSCRITAS");
            list.ForEach(x => Console.WriteLine(x));
            break;

        case "no":
            Console.Clear();
            Console.WriteLine("OK, NO AGREGAMOS TAREAS");
            Console.WriteLine("TUS TAREAS SON");
            list.ForEach(x => Console.WriteLine(x));
            break;

            default:
            Console.WriteLine("Opcion no valida");
            break;
    }

}