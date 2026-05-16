namespace Entidad;

public class Consulta
{
    public DateTime Fecha { get; set; }
    public string DiagnosticoFinal { get; set; }
    public Veterinario Veterinario { get; set; }
    public Mascota Mascota { get; set; }
    public List<LineaTratamiento> LineasTratamientos { get; set; }

    public Consulta(DateTime fecha, string diagnosticoFinal)
    {
        Fecha = fecha;
        DiagnosticoFinal = diagnosticoFinal;
        LineasTratamientos = new List<LineaTratamiento>();
    }

    public void RegistrarMascota()
    {
        throw new ArgumentException();
    }
}