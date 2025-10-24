using SharedKernel.Entities;

namespace GerenciaUsuario.Application.Interfaces;

public interface IUsuarioRepository
{
    Task<int> AdicionarUsuarioAsync(Usuario pessoa, CancellationToken token);

    Task<Usuario> ObterUsuarioPorCPF(string cpf, CancellationToken token);
}
