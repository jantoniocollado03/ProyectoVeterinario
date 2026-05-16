namespace Entidad;

public class Cliente
{
    private string DNI { get; set; }
    private string NombreCompleto { get; set; }
    private string Telefono { get; set; }
    public Mascota Mascota { get; set; }
    

    public Cliente(string dni, string nombreCompleto, string telefono)
    {
        DNI = dni;
        NombreCompleto = nombreCompleto;
        Telefono = telefono;
    }

    public void PagoFactura()
    {
        throw new NotImplementedException();
    }

    public void SolicitudConsulta()
    {
        throw new NotImplementedException();
    }
}