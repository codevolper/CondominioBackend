using SharedKernel.Entities;

namespace GerenciaUsuario.Application.Interfaces;

public interface IUsuarioRepository
{
    Task<int> AdicionarUsuarioAsync(Usuario pessoa);
}
