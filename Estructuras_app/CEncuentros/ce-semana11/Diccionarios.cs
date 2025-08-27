public class Diccionarios
{
    public static void run()
    {
        System.Console.WriteLine("-- Diccionarios --");

        //Definimos un diccionario
        Dictionary<int, string> estudiantes = new Dictionary<int, string>();

        estudiantes.Add(1, "Ana");

        Console.Write("Ingrese una clave: ");
        int clave = int.Parse(Console.ReadLine());

        Console.Write("Nombre del estudiante: ");
        string nombre = Console.ReadLine();



        try
        {
            estudiantes.Add(clave, nombre);
        }
        catch (System.ArgumentException e)
        {
            System.Console.WriteLine("Ha ocurrido un error \n La clave ya existe!!");
        }


        System.Console.WriteLine(estudiantes[clave]);


    }

}