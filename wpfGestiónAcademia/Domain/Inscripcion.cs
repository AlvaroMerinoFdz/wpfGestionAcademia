using System;

public class Inscripcion
{
    public int SocioId { get; private set; }
    public int ClaseId { get; private set; }
    public DateTime Fecha { get; private set; }

    public Inscripcion(int socioId, int claseId)
    {
        SocioId = socioId;
        ClaseId = claseId;
        Fecha = DateTime.Now;
    }
}