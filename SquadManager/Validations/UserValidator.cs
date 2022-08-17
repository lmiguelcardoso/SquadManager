using Common;
using FluentValidation;

namespace SquadManager.Validations
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Email).NotNull().WithMessage("Digite o Email");
            RuleFor(user => user.Password).NotNull().WithMessage("Digite a senha");
        }
    }
}
