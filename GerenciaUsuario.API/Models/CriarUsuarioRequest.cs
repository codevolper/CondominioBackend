using SharedKernel.Enums;

namespace GerenciaUsuario.API.Models;

public class CriarUsuarioRequest
{
    public required string Nome { get; set; }
    public required string Email { get; set; }
    public string Senha { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public required string CPF { get; set; }
    public required TipoUsuario Perfil { get; set; } 
}
