using GerenciaUsuario.Domain.Interfaces;
using SharedKernel.Entities;

namespace GerenciaUsuario.Infrastructure.Persistence;

public class UsuarioRepository : IUsuarioRepository
{
    public Task<Usuario> AdicionarUsuarioAsync(Usuario usuario)
    {
        throw new NotImplementedException();
    }
}
