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
        bool continuar = true; 
        System.Console.WriteLine("Listado de mascotas registradas");
        for (int i = 0; i < _mascotas.Length; i++)
        {
            while (continuar == true)
            {
                if (_mascotas[i].Nombre != null)
                {
                    Console.WriteLine("Mascota " + _mascotas[i].Nombre);
                }
                continuar = false;
                break;

            }
        }
    }
}