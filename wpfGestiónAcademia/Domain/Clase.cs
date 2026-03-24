using System;
using System.Collections.Generic;
using System.Linq;

public class Clase
{
    public int Id { get; private set; }
    public string Nombre { get; private set; }
    public int CapacidadMaxima { get; private set; }

    private List<Inscripcion> _inscripciones = new List<Inscripcion>();

    public IReadOnlyCollection<Inscripcion> Inscripciones => _inscripciones;

    public Clase(string nombre, int capacidadMaxima)
    {
        if (capacidadMaxima <= 0)
            throw new Exception("Capacidad inválida");

        Nombre = nombre;
        CapacidadMaxima = capacidadMaxima;
    }

    public DateTime Fecha { get; private set; }

    public void AgregarInscripcion(Inscripcion inscripcion)
    {
        if (Fecha < DateTime.Now)
            throw new Exception("No puedes inscribirte en clases pasadas");

        if (_inscripciones.Count >= CapacidadMaxima)
            throw new Exception("Clase llena");

        if (_inscripciones.Any(i => i.SocioId == inscripcion.SocioId))
            throw new Exception("El socio ya está inscrito");

        _inscripciones.Add(inscripcion);
    }


}