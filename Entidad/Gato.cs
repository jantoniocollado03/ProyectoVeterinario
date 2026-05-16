namespace Entidad;

public class Gato : Mascota
{
    public bool TestLeucemia { get; set; }

    public Gato(string numChip, string nombre, string especie, double peso) : base(numChip,
        nombre, especie, peso)
    {
        TestLeucemia = false;
    }
}