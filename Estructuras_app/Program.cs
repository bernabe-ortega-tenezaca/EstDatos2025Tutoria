Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("=============================");
Console.WriteLine();

//ceListas.run();
//ceVectores.ejecutar();
System.Console.WriteLine("Pilas");
System.Console.WriteLine("===============");

Stack<int> numeros = new Stack<int>();

numeros.Push(1);
numeros.Push(2);
numeros.Push(20);
numeros.Push(4);

//recorrer los elementos de la pila
foreach (int item in numeros)
{
    System.Console.WriteLine(item);
}

int ultimo = numeros.Peek();

Console.WriteLine("el último elemento es: " + ultimo);
Console.WriteLine("último elemento {0} y el doble de último es {1}", ultimo, ultimo*2);
Console.WriteLine($"último elemento es: {ultimo}");