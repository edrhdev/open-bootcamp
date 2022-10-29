// Escribe un programa que tome la hora y la escriba por pantalla.

Console.Write("Ingresa la hora: ");
//Console.WriteLine("La hora es: {0}", Console.ReadLine() ?? "Hora inválida");

string hora = Console.ReadLine() ?? "Hora inválida";
Console.WriteLine("La hora es: " + hora);

// No usé DateTime porque teóricamente no lo he visto
