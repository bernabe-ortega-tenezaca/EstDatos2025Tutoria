Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("=============================");
System.Console.WriteLine();

//usar cw + TAB
System.Console.WriteLine("Clase encuentro - Arrays");

//Definición de un array
string[] estudiantes = new string[5];

estudiantes[0] = "Maria";
estudiantes[4] = "Paul";

//Recorrido e impresión de los datos
for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine("El elemento " + i + " es " + estudiantes[i]);
}

//ejemplo array inicializado directamente
int[] numeros = { 10, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50 };
for (int i = 0; i < numeros.Length; i++)
{
   System.Console.WriteLine(numeros[i]);
}








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
