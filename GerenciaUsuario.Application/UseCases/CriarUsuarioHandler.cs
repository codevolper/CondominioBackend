using GerenciaUsuario.Application.Interfaces;

namespace GerenciaUsuario.Application.UseCases;

public class CriarUsuarioHandler : ICriarUsuarioHandler
{
    public Task<CriarUsuarioResultado> HandleAsync(CriarUsuarioCommand request)
    {
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
