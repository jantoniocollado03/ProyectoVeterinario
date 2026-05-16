namespace Entidad;

public class Mascota
{
    public string NumChip { get; set; }
    public string Nombre { get; set; }
    public string Especie { get; set; }
    public double Peso { get; set; }

    public Mascota(string numChip, string nombre, string especie, double peso)
    {
        NumChip = numChip;
        Nombre = nombre;
        Especie = especie;
        Peso = peso;
    }
}