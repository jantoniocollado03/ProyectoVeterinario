namespace Entidad;

public class Cliente
{
    public string DNI { get; private set; }
    public string NombreCompleto { get; private set; }
    public string Telefono { get; private set; }
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