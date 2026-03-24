using System.Collections.Generic;

public class ObtenerSociosUseCase
{
    private readonly ISocioRepository _repo;

    public ObtenerSociosUseCase(ISocioRepository repo)
    {
        _repo = repo;
    }

    public List<Socio> Ejecutar()
    {
        return _repo.ObtenerTodos();
    }
}
