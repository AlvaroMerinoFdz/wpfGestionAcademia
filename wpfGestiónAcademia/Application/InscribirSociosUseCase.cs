public class InscribirSocioUseCase
{
    private readonly ISocioRepository _socioRepo;
    private readonly IClaseRepository _claseRepo;

    public InscribirSocioUseCase(
        ISocioRepository socioRepo,
        IClaseRepository claseRepo)
    {
        _socioRepo = socioRepo;
        _claseRepo = claseRepo;
    }

    public void Ejecutar(int socioId, int claseId)
    {
        var socio = _socioRepo.ObtenerPorId(socioId);
        var clase = _claseRepo.ObtenerPorId(claseId);

        var inscripcion = new Inscripcion(socioId, claseId);

        clase.AgregarInscripcion(inscripcion);

        _claseRepo.Guardar(clase);
    }
}