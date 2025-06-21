Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("=============================");
Console.WriteLine();

System.Console.WriteLine("Lista mascotas");
System.Console.WriteLine("==============");

Animal[] mascotas = new Animal[100];

Animal gato = new Animal("Cliff", 23, 2);
Animal perro = new Animal("Firu", 35, 3);

mascotas[0] = gato;
mascotas[1] = perro;






// Animal gato = new Animal("Cliff", 23, 3);

// Console.WriteLine(gato.Edad);
// Console.WriteLine("la edad del gato es: " + gato.Edad);
// Console.WriteLine($"la edad del gato es : {gato.Edad} y el nombre {gato.Nombre}");

// System.Console.WriteLine("Listado de estudiantes");

// clsEstudiante[] estudiantes = new clsEstudiante[10];





// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(estudiantes[i].getNombre());
// }






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
