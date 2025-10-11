using AutoMapper;
using GerenciaUsuario.Application.Interfaces;
using GerenciaUsuario.Application.DataObjects;
using SharedKernel.Entities;

namespace GerenciaUsuario.Application.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IMapper _mapper;
    private readonly IUsuarioRepository _repository;

    public UsuarioService(IMapper mapper, IUsuarioRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<CriarUsuarioResultado> CriarUsuarioAsync(UsuarioRequest request)
    {
        var usuario = new Usuario
        {
            Id = Guid.NewGuid(),
            Nome = request.Nome,
            Email = request.Email,
            Senha = request.Senha,
            Telefone = request.Telefone,
            CPF = request.CPF,
            TipoUsuario = request.TipoUsuario,
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

        var usuariov = _mapper.Map<Usuario>(request);

        var rowsAffected = await _repository.AdicionarUsuarioAsync(usuario);       
        return await Task.FromResult(new CriarUsuarioResultado
        {
            Sucesso = rowsAffected > 0 ? true : false,
            UsuarioId = Guid.NewGuid(),
            Erros = new List<string>()
        });
    }
}
