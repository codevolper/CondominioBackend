using SharedKernel.Enums;

namespace GerenciaUsuario.API.Models;

public class UsuarioRequest
{
    public required string Nome { get; set; }
    public required string Email { get; set; }
    public string Senha { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public required string CPF { get; set; }
    public required TipoUsuario TipoUsuario { get; set; }

    public EnderecoRequest Endereco { get; set; }
}
