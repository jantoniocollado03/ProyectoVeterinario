namespace Entidad;

public class Perro : Mascota
{
    public int NivelAgresividad { get; set; }

    public Perro(string numChip, string nombre, string especie, double peso, int nivelAgresividad) : base(numChip,
        nombre, especie, peso)
    {
        NivelAgresividad = nivelAgresividad;
    }
}