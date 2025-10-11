using FluentValidation;
using GerenciaUsuario.Application.DataObjects;

namespace GerenciaUsuario.Application.Validators;

public class UsuarioRequestValidator : AbstractValidator<UsuarioDTO>
{
    public UsuarioRequestValidator()
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome é obrigatório.")
            .MaximumLength(100).WithMessage("O nome deve ter no máximo 100 caracteres.");
    }
}