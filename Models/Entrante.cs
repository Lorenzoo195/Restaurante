using Models;
public class Entrante : Producto {
    public int NumeroPersonas { get; set; }
    public bool SeSirveFrio { get; set; }

    public Entrante(string nombre, double precio, int numeroPersonas, bool seSirveFrio) 
            : base(nombre, precio) // Pasamos el nombre y precio al constructor del padre (Producto)
        {
            NumeroPersonas = numeroPersonas;
            SeSirveFrio = seSirveFrio;
        }
    public override void ObtenerDescripcion()
    {
            string temperatura = SeSirveFrio ? "Frío" : "Caliente";
            
            Console.WriteLine($"{Nombre} - {Precio} € (Para {NumeroPersonas} personas, {temperatura})");
    }
}