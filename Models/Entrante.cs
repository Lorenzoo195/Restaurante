namespace Models;

public class Entrante : Producto {
    public int NumeroPersonas { get; set; }
    public bool SeSirveFrio { get; set; }

    public Entrante(string nombre, double precio, int numeroPersonas, bool seSirveFrio) 
            : base(nombre, precio) 
        {
            NumeroPersonas = numeroPersonas;
            SeSirveFrio = seSirveFrio;
        }
        
    public override string ObtenerDescripcion()
    {
            string temperatura = SeSirveFrio ? "Frío" : "Caliente";
            
            return $"{Nombre} - {Precio:C}  (Para {NumeroPersonas} personas, {temperatura})";
    }
}