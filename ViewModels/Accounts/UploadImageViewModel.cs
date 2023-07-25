using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Accounts;

public class UploadImageViewModel
{
    // Geralmente o frontend trabalha com imagens, elas geram imagem
    // base64
    [Required]
    public string Base64Image { get; set; }
}
