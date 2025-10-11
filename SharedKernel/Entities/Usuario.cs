using SharedKernel.Enums;
using System.ComponentModel.DataAnnotations;

namespace SharedKernel.Entities
{
    public class Usuario : Pessoa
    {
        [Required(ErrorMessage = "O Email é obrigatório.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatório.")]
        public required string Senha { get; set; }

        [Required(ErrorMessage = "O TipoUsuario é obrigatório.")]
        public required TipoUsuario TipoUsuario { get; set; }
    }
}
