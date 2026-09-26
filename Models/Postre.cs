namespace Models;

using Interfaces;
public class Postre : Producto, IDescontable
{
    public int Calorias { get; set; }

    public Postre(string nombre, double precio, int calorias)
        : base(nombre, precio)
    {
        Calorias = calorias;
    }

    public override string ObtenerDescripcion()
    {
        return $"{Nombre} - {Precio:C} ({Calorias} kcal)";
    }

    public void AplicarDescuento(double porcentaje)
    {
        double cantidadDescontar = Precio * (porcentaje / 100);
        Precio -= cantidadDescontar;
    }
}