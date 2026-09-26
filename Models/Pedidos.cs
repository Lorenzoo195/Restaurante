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
}