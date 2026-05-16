namespace Entidad;

public class Mascota
{
    private string NumChip;
    private string Nombre;
    private string Especie;
    private double Peso;

    public Mascota(string numChip, string nombre, string especie, double peso)
    {
        NumChip = numChip;
        Nombre = nombre;
        Especie = especie;
        Peso = peso;
    }
}