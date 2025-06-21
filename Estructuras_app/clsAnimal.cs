public class Animal
{
    public string Nombre { get; set; }
    public double Largo { get; set; }
    public int Edad { get; set; }

    //Constructor
    public Animal(string _nombre, double _largo, int _edad)
    {
        Nombre = _nombre;
        Largo = _largo;
        Edad = _edad;
    }


    // private string Nombre;

    // //constructor

    // public Animal(string _nombre)
    // {
    //     Nombre = _nombre;

    // }

    // public void SetNombre(string _nombre)
    // {
    //     Nombre = _nombre;
    // }

    // public string GetNombre()
    // {
    //     return Nombre;
    // }


}