using EmailConfirmation.Dtos;
using FluentValidation;

namespace EmailConfirmation.Validations.FluentValidations;

public class UserDetailsValidation : AbstractValidator<UserDetails>
{
    public UserDetailsValidation()
    {
        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.LastName).NotEmpty();
        RuleFor(x => x.BirthDate).Must(x => x.Date < DateTime.UtcNow.Date)
            .WithMessage("Birthdate must be less than datenow");;
    }
}