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

    public async Task<CriarUsuarioResultado> CriarUsuarioAsync(UsuarioRequest request, CancellationToken token)
    {      
        var usuario = _mapper.Map<Usuario>(request);

        var rowsAffected = await _repository.AdicionarUsuarioAsync(usuario, token);       
        return await Task.FromResult(new CriarUsuarioResultado
        {
            Sucesso = rowsAffected > 0 ? true : false,
            UsuarioId = Guid.NewGuid(),
            Erros = new List<string>()
        });
    }

    public async Task<UsuarioRequest> ConsultarUsuarioPorCPFAsync(string cpf, CancellationToken token)
    {
        var usuario = await _repository.ObterUsuarioPorCPF(cpf, token);
        return _mapper.Map<UsuarioRequest>(usuario);
    }
}
