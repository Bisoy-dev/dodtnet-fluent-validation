namespace EmailConfirmation.Dtos;

public class UserDetails
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime BirthDate { get; set; }
}