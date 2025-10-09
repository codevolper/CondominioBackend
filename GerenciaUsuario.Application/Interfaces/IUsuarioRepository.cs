using SharedKernel.Entities;

namespace GerenciaUsuario.Application.Interfaces;

public interface IUsuarioRepository
{
    Task AdicionarUsuarioAsync(Usuario pessoa);
}
