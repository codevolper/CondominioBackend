using GerenciaUsuario.Application.UseCases;

namespace GerenciaUsuario.Application.Interfaces;

public interface ICriarUsuarioHandler
{
    Task<CriarUsuarioResultado> HandleAsync(CriarUsuarioCommand request);
}
