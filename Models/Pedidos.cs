namespace Models;

using Interfaces;

public class Pedido : IDescontable
{
    private List<Producto> productosPedido;

    public Pedido()
    {
        productosPedido = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        productosPedido.Add(producto);
        Console.WriteLine($"{producto.Nombre} añadido al pedido.");
    }

    public double CalcularTotal()
    {
        double total = 0;
        foreach (Producto p in productosPedido)
        {
            total += p.Precio;
        }
        return total;
    }
    public void AplicarDescuento(double porcentaje)
    {
        int productoRebajados = 0;

        foreach (Producto p in productosPedido)
        {
            if (p is IDescontable productoConDescuento)
            {
                productoConDescuento.AplicarDescuento(porcentaje);
                productoRebajados++;
            }
        }
        Console.WriteLine($"\nSe ha aplicado un {porcentaje}% de descuento a {productoRebajados} productos compatibles.");
    }
    public void MostrarPedido()
    {
        Console.WriteLine("\n=== TICKET DEL PEDIDO ===");
    
    if (productosPedido.Count == 0)
    {
        Console.WriteLine("Todavía no has pedido nada.");
        return;
    }
    foreach (Producto p in productosPedido)
    {
        Console.WriteLine($"- {p.Nombre} ........ {p.Precio:C}");
    }
    
    Console.WriteLine("-------------------------");
    Console.WriteLine($"TOTAL A PAGAR: {CalcularTotal():C}");
    Console.WriteLine("=========================\n");
    }
}