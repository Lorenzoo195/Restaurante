using Models;

Entrante bravas = new Entrante("Patatas bravas", 6.50, 2, false);
Entrante nachos = new Entrante("Nachos con queso", 8.00, 3, false);
Entrante ensaladilla = new Entrante("Ensaladilla rusa", 5.00, 2, true);

Console.WriteLine(bravas.ObtenerDescripcion());
Console.WriteLine(nachos.ObtenerDescripcion());
Console.WriteLine(ensaladilla.ObtenerDescripcion());
