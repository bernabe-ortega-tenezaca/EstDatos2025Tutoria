public class ceListas
{

    public static void run()
    {
        Console.WriteLine("  Listas");
        Console.WriteLine("=============================");

        //crear una colección de strings llamada nombres
        List<string> nombres = ["Ana", "Luis", "Rosita"];

        //Añadir elementos a la lista
        nombres.Add("Romina");
        nombres.Add("Willy");
        nombres.Add("Ana");

        //Eliminar elemento de la lista
        nombres.Remove("Ana");

        //Ordenar una lista
        nombres.Sort();

        //imprimir una lista
        foreach (string nombre in nombres)
        {
            System.Console.WriteLine(nombre.ToUpper());
        }

        System.Console.WriteLine($"La lista tiene {nombres.Count} elementos");

   
    }

    

}