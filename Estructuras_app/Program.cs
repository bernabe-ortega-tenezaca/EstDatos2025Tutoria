Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("=============================");
Console.WriteLine();

//ceListas.run();
//ceVectores.ejecutar();
//Pilas.run();

Stack<string> estudiantes = new Stack<string>();

estudiantes.Push("Ana");
estudiantes.Push("Carlos");
Console.WriteLine("Ingrese un nombre");
estudiantes.Push(Console.ReadLine());
estudiantes.Push("Juan");

Pilas.ImprimirPila(estudiantes);