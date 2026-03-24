

public class PoliticaInscripcion
{
    public bool PuedeInscribirse(int clasesEstaSemana)
    {
        return clasesEstaSemana < 3;
    }
}
