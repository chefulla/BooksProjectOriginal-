namespace BooksProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public bool Rating { get; set; }
        public int Reviews { get; set; }
    }
}
