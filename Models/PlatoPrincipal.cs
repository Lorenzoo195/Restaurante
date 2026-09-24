namespace Models;

public class PlatoPrincipal : Producto
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
}