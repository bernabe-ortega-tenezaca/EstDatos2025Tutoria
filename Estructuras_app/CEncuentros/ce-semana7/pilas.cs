public class Pilas
{
    public static void run()
    {
        System.Console.WriteLine("Pilas");
        System.Console.WriteLine("===============");

        Stack<int> numeros = new Stack<int>();

        numeros.Push(1);
        numeros.Push(2);
        numeros.Push(20);
        numeros.Push(4);

        //recorrer los elementos de la pila
        foreach (int item in numeros)
        {
            System.Console.WriteLine(item);
        }

        int ultimo = numeros.Peek();

        Console.WriteLine("el último elemento es: " + ultimo);
        Console.WriteLine("último elemento {0} y el doble de último es {1}", ultimo, ultimo * 2);
        Console.WriteLine($"último elemento es: {ultimo}");

        //Eliminar elementos
        numeros.Pop();
        int eliminado = numeros.Pop();
        System.Console.WriteLine();


        //recorrer los elementos de la pila
        foreach (int item in numeros)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("elemento eliminado: " + eliminado);

    }

    public static void ImprimirPila(Stack<string> pila)
    {
        System.Console.WriteLine("Los elementos de la pila son: ");
        foreach (var item in pila)
        {
            System.Console.WriteLine(item);
        }
    }


}