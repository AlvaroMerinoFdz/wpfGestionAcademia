public class CrearSocioUseCase
{
    private readonly ISocioRepository _repo;

    public CrearSocioUseCase(ISocioRepository repo)
    {
        _repo = repo;
    }

    public void Ejecutar(string nombre, string email)
    {
        var socio = new Socio(nombre, email);
        _repo.Agregar(socio);
    }
}