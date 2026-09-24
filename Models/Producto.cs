namespace Restaurante.Modles;

public abstract class Producto
{
    public string Nombre {get; set;}
    public string Precio {get; set;}


public Producto(string nombre, string precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
public abstract string ObtenerDescripcion();

}