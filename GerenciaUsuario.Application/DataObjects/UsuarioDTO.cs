using SharedKernel.Enums;

namespace GerenciaUsuario.Application.DataObjects;

public class UsuarioDTO
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public  required string CPF { get; set; }
    public  required TipoUsuario TipoUsuario { get; set; }
    public EnderecoDTO Endereco { get; set; }
}
