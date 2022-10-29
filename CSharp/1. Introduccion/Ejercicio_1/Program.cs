// Escribe un programa que reciba tu nombre y lo escriba por consola.

Console.Write("Ingresa tu nombre: ");
//Console.WriteLine("Tu nombre es: {0}", Console.ReadLine() ?? "Nombre inválido");

string nombre = Console.ReadLine() ?? "Nombre invalido";
Console.WriteLine("Tu nombre es: {0}", nombre);
