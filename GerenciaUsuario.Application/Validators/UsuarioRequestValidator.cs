using FluentValidation;
using GerenciaUsuario.Application.DataObjects;

namespace GerenciaUsuario.Application.Validators;

public class UsuarioRequestValidator : AbstractValidator<UsuarioRequest>
{
    public UsuarioRequestValidator()
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome é obrigatório.")
            .MaximumLength(100).WithMessage("O nome deve ter no máximo 100 caracteres.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("O email é obrigatório.")
            .EmailAddress().WithMessage("O email deve ser um endereço válido.");

        RuleFor(x => x.CPF)
            .NotEmpty().WithMessage("O CPF é obrigatório.")
            .Matches(@"^\d{11}$").WithMessage("O CPF deve conter exatamente 11 dígitos numéricos.");

        RuleFor(x => x.Senha)
            .NotEmpty().WithMessage("A senha é obrigatória.")
            .MinimumLength(6).WithMessage("A senha deve ter no mínimo 6 caracteres.");

        RuleFor(x => x.TipoUsuario)
            .IsInEnum().WithMessage("O tipo de usuário é inválido.");
    }
}