public class Colas
{
    public static void run()
    {
        Queue<string> autos = new Queue<string>();

        autos.Enqueue("Lada");
        autos.Enqueue("Audi");
        autos.Enqueue("Opel");
        autos.Enqueue("BMW");


        //autos.Dequeue();
        string autoAtendido = autos.Dequeue(); //Extrae el primer elemento de la cola

        Console.WriteLine("Vendido: " + autoAtendido );
        int porVender = autos.Count();
        Console.WriteLine("tenemos " + porVender + " por vender");

        cantidadElementos(autos);

        imprimirCola(autos);
    }

    public static void cantidadElementos(Queue<string> cola)
    {
        System.Console.WriteLine();
        Console.WriteLine("Existen " + cola.Count() + " elementos en cola");

    }
    public static void imprimirCola(Queue<string> cola)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Los elementos de la cola son:");
        foreach (var item in cola)
        {
            System.Console.WriteLine(item);
        }
    }

}