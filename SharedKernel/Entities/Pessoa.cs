using SharedKernel.Enums;

namespace SharedKernel.Entities;

public abstract class Pessoa
{
    public Guid Id { get; set; }

    public required string Nome { get; set; }

    public required string Cpf { get; set; }

    public required string Email { get; set; }

    public required string Telefone { get; set; }

    public required TipoUsuario TipoUsuario { get; set; }
    
    public Endereco? Endereco { get; set; }
}
