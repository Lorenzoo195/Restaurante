using Models;

public class Bebida : Producto
{
    public bool EsAlcoholica {get; set;}

public Bebida (string nombre, double precio, bool esAlcoholica): base (nombre, precio)
    {
        EsAlcoholica = esAlcoholica;
    }
    public override string ObtenerDescripcion()
    {
        string tipo = EsAlcoholica ? "Con alcohol" : "Sin alcohol";
        return $"{Nombre} - {Precio:C}  ({tipo})";
    }
}