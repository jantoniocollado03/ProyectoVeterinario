namespace Entidad;

public class LineaTratamiento
{
    public string Concepto { get; private set; }
    public decimal Precio { get; private set; }

    public LineaTratamiento(string concepto, decimal precio)
    {
        Concepto = concepto;
        Precio = precio;
    }
}