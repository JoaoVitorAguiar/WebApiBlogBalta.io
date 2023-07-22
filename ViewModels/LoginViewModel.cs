using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels;
public class LoginViewModel
{
    [Required]
    [EmailAddress] // Valida se é e-mail
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}

