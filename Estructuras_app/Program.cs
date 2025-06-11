Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("=============================");
System.Console.WriteLine();

Cuadrado mi_cuadrado = new Cuadrado(4);
Console.WriteLine("El área del cuadrado es: " + mi_cuadrado.area());
System.Console.WriteLine();

Asignatura matematicas = new Asignatura("matematicas", [12, 13, 18]);

System.Console.WriteLine(matematicas.getAsignatura());
System.Console.WriteLine(matematicas.getNotas());

double[] minotas = matematicas.getNotas();
System.Console.WriteLine(minotas[0]);
System.Console.WriteLine(minotas[1]);
System.Console.WriteLine(minotas[2]);
