using System.ComponentModel.DataAnnotations;

namespace EmailConfirmation.Validations.ValidationAttributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
public class BirthdateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        return (value is DateTime birthDate && birthDate.Date < DateTime.Now.Date) ? ValidationResult.Success : new ValidationResult("Brithdate must be less than date now.");
    }
}