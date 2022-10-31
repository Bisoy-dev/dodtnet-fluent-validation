using System.ComponentModel.DataAnnotations;
using EmailConfirmation.Validations.ValidationAttributes;

namespace EmailConfirmation.Dtos;

public class RegisterAccount
{
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string ConfirmPassword { get; set; } = null!;
    public UserDetails Details { get; set; } = null!;
}