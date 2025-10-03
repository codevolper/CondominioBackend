namespace GerenciaUsuario.Application.UseCases;

public class CriarUsuarioCommand
{
    public required string Nome { get; set; }
    public required string Email { get; set; }
    public string Senha { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public  required string CPF { get; set; }
    public  required string Perfil { get; set; }  
}
