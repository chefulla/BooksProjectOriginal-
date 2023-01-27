using BooksProject.Models.BooksModels;

namespace BooksProject.Models.ViewModels
{
    public class BooksViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public virtual GenreModel GenreModel { get; set; }
        public virtual PriceModel PriceModel{ get; set; }
        public virtual RatingModel RatingModel { get; set; }
        public virtual ReviewModel ReviewModel { get; set; }
    }
}
