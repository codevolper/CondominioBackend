using SharedKernel.Enums;
using System.ComponentModel.DataAnnotations;

namespace SharedKernel.Entities;

public abstract class Pessoa
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O Nome é obrigatório.")]
    public required string Nome { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    public required string CPF { get; set; }

    [Required(ErrorMessage = "O Telefone é obrigatório.")]
    public required string Telefone { get; set; }

    //Navigation property
    public Endereco Endereco { get; set; } = null!;
}
