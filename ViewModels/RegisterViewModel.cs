using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels;
public class RegisterViewModel
{
    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress] // Valida se é e-mail
    public string Email { get; set; }
}