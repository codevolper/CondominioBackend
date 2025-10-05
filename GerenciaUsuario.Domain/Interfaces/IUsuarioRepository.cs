using SharedKernel.Entities;

namespace GerenciaUsuario.Domain.Interfaces;

public interface IUsuarioRepository
{
    Task<Usuario> AdicionarUsuarioAsync(Usuario pessoa);
}
