using SharedKernel.Enums;

namespace SharedKernel.Entities;

public abstract class Pessoa
{
    public Guid Id { get; set; }

    public required string Nome { get; set; }

    public required string CPF { get; set; }    

    public required string Telefone { get; set; }

    //Navigation property
    public Endereco Endereco { get; set; } = null!;
}
