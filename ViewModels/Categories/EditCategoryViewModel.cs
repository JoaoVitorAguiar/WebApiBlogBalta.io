using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Categories
{
    public class EditCategoryViewModel
    {
        // Pode ser assim também: [Required(ErrorMessege = "msg pernsonalizada")]
        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Slug { get; set; }
    }
}
