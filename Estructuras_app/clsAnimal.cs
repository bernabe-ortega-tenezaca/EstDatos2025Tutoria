public class Animal
{
    private string Nombre;

    //constructor

    public Animal(string _nombre)
    {
        Nombre = _nombre;

    }

    public void SetNombre(string _nombre)
    {
        Nombre = _nombre;
    }

    public string GetNombre()
    {
        return Nombre;
    }


}