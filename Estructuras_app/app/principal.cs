
public class MenuPrincipal
{
    private bool continuar = true;

    public void Iniciar()
    {
        while (continuar)
        {
            MostrarMenu();
            string opcion = LeerOpcion();
            EjecutarOpcion(opcion);
            EsperarTecla();
        }
    }

    private void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("=== MENÚ PRINCIPAL ===");
        Console.WriteLine("1. Vectores");
        Console.WriteLine("2. Listas");
        Console.WriteLine("3. Pilas");
        Console.WriteLine("14. Arboles");
        Console.WriteLine("15. Grafos");
        Console.WriteLine("16. Salir");
        Console.Write("Selecciona una opción: ");
    }

    private string LeerOpcion()
    {
        return Console.ReadLine();
    }

    private void EjecutarOpcion(string opcion)
    {
        switch (opcion)
        {
            case "1":
                ceVectores.ejecutar();
                break;
            case "2":
                ceListas.run();
                break;
            case "3":
            case "4":
                Pilas.run();
                break;
            case "15":
                Grafos.run();
                break;
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "13":
            case "14":
                arboles.run();
                break;
            case "16":    
                MostrarMensajeSalida();
                continuar = false;
                break;
            default:
                Console.WriteLine("Opción inválida. Intenta de nuevo.");
                break;
        }
    }

    private void MostrarMensajeSalida()
    {
        Console.WriteLine("Saliendo... ¡Hasta pronto!");
    }

    private void EsperarTecla()
    {
        if (continuar)
        {
            Console.WriteLine("\nPresiona la tecla enter para volver al menú...");
            Console.ReadLine();
        }
    }
}
