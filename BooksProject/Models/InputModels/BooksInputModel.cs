using BooksProject.Models.BooksModels;
using System.ComponentModel.DataAnnotations;

namespace BooksProject.Models.InputModels
{
    public class BooksInputModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Exceeding the limits", MinimumLength = 1)]
        public string Title { get; set; }

        public int Year { get; set; }
        
        [Required]
        public virtual GenreModel GenreModel { get; set; }
        
        [Required]
        public virtual RatingModel RatingModel { get; set; }
        
        [Required]
        public virtual ReviewModel ReviewModel { get; set; }

        [Required]
        public virtual PriceModel PriceModel { get; set; }
    }
}
