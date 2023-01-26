using BooksProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksProject.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<GenreModel> GenreModels { get; set; }
        public DbSet<PriceModel> PriceModels { get; set; }
        public DbSet<RatingModel> RatingModels { get; set; }
        public DbSet<ReviewModel> ReviewsModels { get; set; }
        public DbSet<YearModel> YearModels { get; set; }
    }
}
