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
    if (p is Bebida)
    {
        Console.WriteLine($"{contador}. {p.ObtenerDescripcion()}");
        contador++;
    }
}