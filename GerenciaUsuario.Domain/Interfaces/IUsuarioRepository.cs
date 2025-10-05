using SharedKernel.Entities;

namespace GerenciaUsuario.Domain.Interfaces;

public interface IUsuarioRepository
{
    Task AdicionarUsuarioAsync(Usuario pessoa);
}
