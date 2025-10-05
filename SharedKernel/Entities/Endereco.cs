namespace SharedKernel.Entities;

public class Endereco
{
    public int Id { get; set; }
    public string Logradouro { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;
    public string Complemento { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public string Cep { get; set; } = string.Empty;

    // Foreign key to Pessoa
    public Guid PessoaId { get; set; }

    public Pessoa Pessoa { get; set; } = null!;
}
