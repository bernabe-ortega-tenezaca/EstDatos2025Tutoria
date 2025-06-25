public class RegistroAnimal
{
    public Animal[] _mascotas { get; set; }
    public RegistroAnimal(Animal[] mascotas)
    {
        _mascotas = mascotas;
    }

    public void setNuevoAnimal(Animal _mascota, int posicion)
    {
        _mascotas[posicion] = _mascota;
    }
}