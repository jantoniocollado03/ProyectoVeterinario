namespace Entidad;

public class LineaTratamiento
{
    public string Concepto { get; set; }
    public decimal Precio { get; set; }

    public LineaTratamiento(string concepto, decimal precio)
    {
        Concepto = concepto;
        Precio = precio;
    }
}