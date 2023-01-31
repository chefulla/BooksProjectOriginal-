using BooksProject.Models.BooksModels;
using Microsoft.EntityFrameworkCore;

namespace BooksProject.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Book> Books { get; set; }
       
    }
}
