Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("=============================");
Console.WriteLine();

bool continuar = true;
while (continuar)
{
    Console.Clear();
    Console.WriteLine("=== MENÚ PRINCIPAL ===");
    Console.WriteLine("1. Vectores");
    Console.WriteLine("2. Listas");
    Console.WriteLine("3. Salir");
    Console.Write("Selecciona una opción: ");
    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            ceVectores.ejecutar();
            break;
        case "2":
            ceListas.run();
            break;
        case "3":
            Pilas.run();
            break;
        case "4":
            Pilas.run();
            break;
        case "5":
            Console.WriteLine("Saliendo... ¡Hasta pronto!");
            continuar = false;
            break;
        case "6":
            Console.WriteLine("Saliendo... ¡Hasta pronto!");
            continuar = false;
            break;
        case "7":
            Console.WriteLine("Saliendo... ¡Hasta pronto!");
            continuar = false;
            break;
        case "8":
            Console.WriteLine("Saliendo... ¡Hasta pronto!");
            continuar = false;
            break;
        case "9":
            Console.WriteLine("Saliendo... ¡Hasta pronto!");
            continuar = false;
            break;
        case "13":
            Console.WriteLine("Saliendo... ¡Hasta pronto!");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción inválida. Intenta de nuevo.");
            break;
    }
    if (continuar)
    {
        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
        Console.ReadKey();
    }
}



//ceListas.run();
//ceVectores.ejecutar();
//Pilas.run();
// Colas.run();


// Queue<string> nombres = new Queue<string>();
// nombres.Enqueue("Ana");
// Colas.imprimirCola(nombres);

//vacunas.run();
//Diccionarios.run();
//ClaveValor.run();