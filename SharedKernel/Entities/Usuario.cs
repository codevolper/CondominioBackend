using SharedKernel.Enums;

namespace SharedKernel.Entities
{
    public class Usuario : Pessoa
    {
        public required string Email { get; set; }

        public required string Senha { get; set; }

        public required TipoUsuario TipoUsuario { get; set; }
    }
}
