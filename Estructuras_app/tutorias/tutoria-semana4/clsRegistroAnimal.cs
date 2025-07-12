public class RegistroAnimal
{
    public Animal[] _mascotas { get; set; }

    /// <summary>
    /// Constructor de la clase mascota
    /// </summary>
    /// <param name="mascotas"></param>
    public RegistroAnimal(int MaximoMascotas)
    {
        _mascotas = new Animal[MaximoMascotas];
    }

    public void IngresoNuevaMascota(Animal _mascota, int posicion)
    {
        _mascotas[posicion] = _mascota;
    }

    public void imprimirMascotas()
    {
        Console.WriteLine("Listado de mascotas registradas");
        System.Console.WriteLine("===========================");

        for (int i = 0; i < _mascotas.Length; i++)
        {
            //while (continuar == true)
            //{
            if (_mascotas[i] != null)
            {
                Console.WriteLine("Mascota " + _mascotas[i].Nombre);
            }
            //     else
            //     {
            //         continuar = false;
            //     }
            // }
        }
    }

/// <summary>
/// Método buscar: Busca un nombre de mascota en el registro
/// </summary>
/// <param name="nombreMascota">Ingrese el nombre a buscar</param>
    public void buscar(string nombreMascota)
    {
        Console.WriteLine();
        Console.WriteLine("Búsqueda de mascota");
        System.Console.WriteLine("===========================");
        if (encontrar(nombreMascota))
        {
            Console.WriteLine("El registro ha sido encontrado");
        }
        else
        {
            Console.WriteLine("No se encuentra el registro");
        }
    }


/// <summary>
/// Propiedad privada para busca un valor
/// </summary>
/// <param name="nombre">String nombre para buscar</param>
/// <returns>true o false</returns>
    private bool encontrar(string nombre)
    {
        bool encontrado = false;

        for (int i = 0; i < _mascotas.Length; i++)
        {
            if (_mascotas[i] != null)
            {
                if (nombre == _mascotas[i].Nombre)
                {
                    encontrado = true;
                }
            }
        }

        return encontrado;
    }
}