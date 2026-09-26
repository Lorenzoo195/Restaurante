using Models;

Entrante bravas = new Entrante("Patatas bravas", 6.50, 2, false);
Entrante ensaladilla = new Entrante("Ensaladilla rusa", 5.00, 2, true);

Bebida agua = new Bebida("Agua mineral", 2.00, false);
Bebida cerveza = new Bebida("Cerveza", 3.00, true);

PlatoPrincipal hamburguesa = new PlatoPrincipal("Hamburguesa XXL", 12.00, false);
PlatoPrincipal pizza = new PlatoPrincipal("Pizza Margarita", 11.00, true);

Postre tarta = new Postre("Tarta de queso", 5.00, 450);
Postre flan = new Postre("Flan casero", 4.00, 300);

List<Producto> carta = new List<Producto>();
carta.Add(bravas);
carta.Add(ensaladilla);
carta.Add(agua);
carta.Add(cerveza);
carta.Add(hamburguesa);
carta.Add(pizza);
carta.Add(tarta);
carta.Add(flan);

Console.WriteLine("Carta");
Console.WriteLine();

int contador = 1;
foreach (Producto p in carta)
{
    Console.WriteLine($"{contador}. {p.ObtenerDescripcion()}");
    contador++;
}

Console.Write("\n¿Qué producto quieres? ");
string entrada = Console.ReadLine(); 
if (int.TryParse(entrada, out int opcion))
{
    if (opcion >= 1 && opcion <= carta.Count)
    {
        Producto elegido = carta[opcion - 1]; 
        Console.WriteLine($"\nHas elegido:\n{elegido.Nombre} - {elegido.Precio:C}");
    }
    else
    {
        Console.WriteLine("\nEse producto no existe.");
    }
}
else
{
    Console.WriteLine("\nDebes introducir un número válido.");
}

Console.Write("\nProducto a buscar: ");
string textoBusqueda = Console.ReadLine();
bool encontrado = false; 

foreach (Producto p in carta)
{
    
    if (p.Nombre.ToLower() == textoBusqueda.ToLower())
    {
        Console.WriteLine("\nProducto encontrado:");
        Console.WriteLine($"{p.Nombre} - {p.Precio:C}");
        encontrado = true; 
        break; 
    }
}

if (!encontrado)
{
    Console.WriteLine("\nNo se ha encontrado el producto.");
}


Console.Write("\nPrecio máximo: ");
string entradaPrecio = Console.ReadLine();

if (double.TryParse(entradaPrecio, out double precioMaximo))
{
    bool hayProductos = false;
    Console.WriteLine($"\nProductos de hasta {precioMaximo:C}:");

    foreach (Producto p in carta)
    {
        if (p.Precio <= precioMaximo)
        {
            Console.WriteLine($"{p.Nombre} - {p.Precio:C}");
            hayProductos = true;
        }
    }

    if (!hayProductos)
    {
        Console.WriteLine("No existe ningún producto por ese precio o menos.");
    }
}
else
{
    Console.WriteLine("\nDebes introducir un precio numérico válido.");
}



if (carta.Count > 0)
{
    Producto masCaro = carta[0]; 

    foreach (Producto p in carta)
    {
        if (p.Precio > masCaro.Precio)
        {
            masCaro = p; 
    }

    Console.WriteLine("\nEl producto más caro es:");
    Console.WriteLine($"{masCaro.Nombre} - {masCaro.Precio:C}");
}
}