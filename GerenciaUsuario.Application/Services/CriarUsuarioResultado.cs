namespace GerenciaUsuario.Application.Services;

public class CriarUsuarioResultado
{
    public Guid UsuarioId { get; set; }

    public bool Sucesso { get; set; }
        
    public List<string> Erros { get; set; }        

    public static CriarUsuarioResultado Falha(params string[] erros) =>
        new() { Sucesso = false, Erros = erros.ToList() };
}
