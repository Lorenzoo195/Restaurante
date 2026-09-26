namespace Models;

using Interfaces;

public class PlatoPrincipal : Producto, IDescontable
{
    public bool EsVegano { get; set; }

    public PlatoPrincipal(string nombre, double precio, bool esVegano)
        : base(nombre, precio)
    {
        EsVegano = esVegano;
    }

    public override string ObtenerDescripcion()
    {
        string vegano = EsVegano ? "(Vegano)" : "";
        return $"{Nombre} - {Precio:C}  {vegano}";
    }

    public void AplicarDescuento(double porcentaje)
    {
        double cantidadDescontar = Precio * (porcentaje / 100);
        Precio -= cantidadDescontar;
    }
}