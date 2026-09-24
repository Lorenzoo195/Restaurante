namespace Models;

public class Postre : Producto
{
    public int Calorias { get; set; }

    public Postre(string nombre, double precio, int calorias) 
        : base(nombre, precio)
    {
        Calorias = calorias;
    }

    public override string ObtenerDescripcion()
    {
        return $"{Nombre} - {Precio} EUR ({Calorias} kcal)";
    }
}