namespace Entidad;

public class Mascota
{
    public string NumChip { get; private set; }
    public string Nombre { get; private set; }
    public string Especie { get; private set; }
    public double Peso { get; private set; }

    public Mascota(string numChip, string nombre, string especie, double peso)
    {
        NumChip = numChip;
        Nombre = nombre;
        Especie = especie;
        Peso = peso;
    }
}