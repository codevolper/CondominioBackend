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
            TipoUsuario  = request.TipoUsuario,
            Endereco = new Endereco
            {
                Logradouro = request.Endereco?.Logradouro ?? string.Empty,
                Numero = request.Endereco?.Numero ?? string.Empty,
                Complemento = request.Endereco?.Complemento ?? string.Empty,
                Bairro = request.Endereco?.Bairro ?? string.Empty,
                Cidade = request.Endereco?.Cidade ?? string.Empty,
                Estado = request.Endereco?.Estado ?? string.Empty,
                Cep = request.Endereco?.Cep ?? string.Empty
            }
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
