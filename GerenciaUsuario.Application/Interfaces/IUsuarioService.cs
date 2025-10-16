using GerenciaUsuario.Application.DataObjects;
using GerenciaUsuario.Application.Services;

namespace GerenciaUsuario.Application.Interfaces;

public interface IUsuarioService
{
    Task<CriarUsuarioResultado> CriarUsuarioAsync(UsuarioRequest request);

    Task<UsuarioRequest> ConsultarUsuarioPorCPFAsync(string cpf);
}
