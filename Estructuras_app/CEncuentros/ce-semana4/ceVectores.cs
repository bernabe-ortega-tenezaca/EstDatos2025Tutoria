public class ceVectores
{
    public static void ejecutar()
    {
        RegistroAnimal registro = new RegistroAnimal(10);

        Animal gato = new Animal("Cliff", 23, 2);
        Animal perro = new Animal("Firu", 35, 3);
        Animal vaca = new Animal("Lechera", 2.5, 4);

        registro.IngresoNuevaMascota(gato, 0);
        registro.IngresoNuevaMascota(perro, 1);
        registro.IngresoNuevaMascota(vaca, 2);

        registro.imprimirMascotas();

        Console.WriteLine("Ingrese el nombre de la mascota a buscar");
        registro.buscar(Console.ReadLine());
        registro.buscar("Fir");

        int max = 10;

        Animal[] mascotas = new Animal[max];


        mascotas[0] = gato;
        mascotas[1] = perro;
        mascotas[2] = vaca;

        //imprimir el vector
        bool continuar = true;
        int i = 0;
        while (continuar)
        {
            if (mascotas[i] != null) //boolean
            {
                Console.WriteLine("Nombre: " + mascotas[i].Nombre + " Edad: " + mascotas[i].Edad);
                i++;
            }
            else
            {
                continuar = false;
            }
        }

        continuar = true;
        bool encontrado = false;

        string consulta = "Firulais";
        i = 0;
        while (continuar)
        {
            if (mascotas[i] != null) //boolean
            {
                if (string.Compare(mascotas[i].Nombre, consulta) > 0)
                {
                    encontrado = true;
                }
                i++;
            }
            else
            {
                continuar = false;
            }
        }


        if (encontrado)
        {
            System.Console.WriteLine("El registro ha sido encontrado");
        }
        else
        {
            System.Console.WriteLine("El registro no existe");
        }
        
        // //Recorrido del array
        // // for (int i = 0; i < max; i++)
        // // {
        // //     System.Console.WriteLine(mascotas[i].Nombre);
        // // }
        // // foreach (var item in mascotas)
        // // {
        // //     System.Console.WriteLine(item.Nombre);
        // // }




        // // Animal gato = new Animal("Cliff", 23, 3);

        // // Console.WriteLine(gato.Edad);
        // // Console.WriteLine("la edad del gato es: " + gato.Edad);
        // // Console.WriteLine($"la edad del gato es : {gato.Edad} y el nombre {gato.Nombre}");

        // // System.Console.WriteLine("Listado de estudiantes");

        // // clsEstudiante[] estudiantes = new clsEstudiante[10];





        // // for (int i = 0; i < 10; i++)
        // // {
        // //     Console.WriteLine(estudiantes[i].getNombre());
        // // }






        // string[] telf = new string[2];
        // telf[0] = "098787877";
        // telf[1] = "098989898";

        // clsEstudiante estudiante = new clsEstudiante();
        // clsEstudiante estudiante1 = new clsEstudiante("123", "Juana", telf);

        // //usar cw + TAB
        // System.Console.WriteLine("Clase encuentro - Arrays");

        // //Definición de un array
        // string[] estudiantes = new string[5];

        // estudiantes[0] = "Maria";
        // estudiantes[4] = "Paul";

        // //Recorrido e impresión de los datos
        // for (int i = 0; i < 5; i++)
        // {
        //     System.Console.WriteLine("El elemento " + i + " es " + estudiantes[i]);
        // }

        // //ejemplo array inicializado directamente
        // int[] numeros = { 10, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50 };
        // for (int i = 0; i < numeros.Length; i++)
        // {
        //    System.Console.WriteLine(numeros[i]);
        // }








        // Cuadrado mi_cuadrado = new Cuadrado(4);
        // Console.WriteLine("El área del cuadrado es: " + mi_cuadrado.area());
        // System.Console.WriteLine();

        // Asignatura matematicas = new Asignatura("matematicas", [12, 13, 18]);

        // System.Console.WriteLine(matematicas.getAsignatura());
        // System.Console.WriteLine(matematicas.getNotas());

        // double[] minotas = matematicas.getNotas();
        // System.Console.WriteLine(minotas[0]);
        // System.Console.WriteLine(minotas[1]);
        // System.Console.WriteLine(minotas[2]);
    }

}