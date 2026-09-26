namespace Models;

public class Pedido
{
    private List<Producto> productosPedido;

    public Pedido(){
        productosPedido = new List<Producto>();
    }

    public void AgregarProducto (Producto producto)
    {
        productosPedido.Add(producto);
        Console.WriteLine($"{producto.Nombre} añadido al pedido.");
    }

    public double CalcularTotal()
    {
        double total = 0;
        foreach(Producto p in productosPedido)
        {
            total +=p.Precio;
        }
        return total;
    }

}