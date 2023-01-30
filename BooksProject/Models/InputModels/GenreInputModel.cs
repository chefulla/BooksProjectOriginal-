using System.ComponentModel.DataAnnotations;

namespace BooksProject.Models.InputModels
{
    public class GenreInputModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Exceeding the limits", MinimumLength = 1)]
        public string Genre { get; set; }
    }
}
