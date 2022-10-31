using EmailConfirmation.Dtos;
using FluentValidation;

namespace EmailConfirmation.Validations.FluentValidations;

public class RegisterAccountValidation : AbstractValidator<RegisterAccount>
{
    public RegisterAccountValidation()
    {
        RuleFor(x => x.Username).Length(4, 8)
            .WithMessage("Username must between 4 and 8");
        RuleFor(x => x.Password).Length(4, 8)
            .WithMessage("Password must have more than 4 and less than 8 characters.");
        RuleFor(x => x.ConfirmPassword).Equal(x => x.Password);
        RuleFor(x => x.Details).SetValidator(new UserDetailsValidation());

    }
}