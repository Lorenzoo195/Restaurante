using Models;

public class MenuApp
{
    private List<Producto> carta;
    private const int OpcionSalir = 0;

    public MenuApp(List<Producto> lista)
    {
        carta = lista;
    }

    public void Iniciar()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n========================");
            Console.WriteLine("      RESTAURANTE       ");
            Console.WriteLine("========================");
            Console.WriteLine("1. Ver carta");
            Console.WriteLine("2. Buscar producto");
            Console.WriteLine("3. Productos por precio");
            Console.WriteLine("4. Producto más caro");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Selecciona una opción:");

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 4)
            {
                Console.WriteLine("Error: selecciona una opción válida (0-4).");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    MostrarCarta();
                    break;
                case 2:
                    BuscarProducto();
                    break;
                case 3:
                    MostrarProductosPorPrecio();
                    break;
                case 4:
                    MostrarProductoMasCaro();
                    break;
                case OpcionSalir:
                    Console.WriteLine("¡Hasta pronto!");
                    break;
            }

        } while (opcion != OpcionSalir);
    }

    private void MostrarCarta()
    {
        Console.WriteLine("\n=== CARTA ===");
        int contador = 1;
        foreach (Producto p in carta)
        {
            Console.WriteLine($"{contador}. {p.ObtenerDescripcion()}");
            contador++;
        }
    }

    private void BuscarProducto()
    {
        Console.Write("\nProducto a buscar: ");
        string textoBusqueda = Console.ReadLine();
        bool encontrado = false;

        foreach (Producto p in carta)
        {
            if (p.Nombre.ToLower() == textoBusqueda.ToLower())
            {
                Console.WriteLine($"Producto encontrado: {p.Nombre} - {p.Precio:C}");
                encontrado = true;
                break;
            }
        }
        if (!encontrado) Console.WriteLine("No se ha encontrado el producto.");
    }

    private void MostrarProductosPorPrecio()
    {
        Console.Write("\nPrecio máximo: ");
        if (double.TryParse(Console.ReadLine(), out double precioMaximo))
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
            if (!hayProductos) Console.WriteLine("No existe ningún producto por ese precio o menos.");
        }
        else
        {
            Console.WriteLine("Debes introducir un precio numérico válido.");
        }
    }

    private void MostrarProductoMasCaro()
    {
        if (carta.Count > 0)
        {
            Producto masCaro = carta[0];
            foreach (Producto p in carta)
            {
                if (p.Precio > masCaro.Precio) masCaro = p;
            }
            Console.WriteLine("\nEl producto más caro es:");
            Console.WriteLine($"{masCaro.Nombre} - {masCaro.Precio:C}");
        }
    }
}