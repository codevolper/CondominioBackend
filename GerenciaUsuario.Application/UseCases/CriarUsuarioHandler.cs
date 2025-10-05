using GerenciaUsuario.Application.Interfaces;
using GerenciaUsuario.Domain.Interfaces;
using SharedKernel.Entities;

namespace GerenciaUsuario.Application.UseCases;

public class CriarUsuarioHandler : ICriarUsuarioHandler
{
    private readonly IUsuarioRepository _repository;

    public CriarUsuarioHandler(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public Task<CriarUsuarioResultado> HandleAsync(CriarUsuarioCommand request)
    {
        var usuario = new Usuario
        {
            Id = Guid.NewGuid(),
            Nome = request.Nome,
            Email = request.Email,
            Senha = request.Senha,
            Telefone = request.Telefone,
            CPF = request.CPF,
            TipoUsuario  = request.Perfil
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
