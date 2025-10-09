using GerenciaUsuario.Application.DataObjects;
using GerenciaUsuario.Application.Interfaces;
using SharedKernel.Entities;

namespace GerenciaUsuario.Application.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _repository;

    public UsuarioService(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public Task<CriarUsuarioResultado> CriarUsuarioAsync(UsuarioDTO request)
    {
        var usuario = new Usuario
        {
            Id = Guid.NewGuid(),
            Nome = request.Nome,
            Email = request.Email,
            Senha = request.Senha,
            Telefone = request.Telefone,
            CPF = request.CPF,
            TipoUsuario  = request.TipoUsuario
        };

        _repository.AdicionarUsuarioAsync(usuario);
        // Lógica para criar o usuário (validação, persistência, etc.)
        // Aqui você pode chamar repositórios, serviços, etc.
        // Exemplo simplificado de resultado
        var resultado = new CriarUsuarioResultado
        {
            Sucesso = true,
            UsuarioId = Guid.NewGuid(),
            Erros = new List<string>()
        };
        return Task.FromResult(resultado);
    }
}
