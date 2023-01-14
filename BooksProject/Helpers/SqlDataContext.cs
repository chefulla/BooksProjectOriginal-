using Microsoft.EntityFrameworkCore;

namespace BooksProject.Helpers
{
    public class SqlDataContext : DataContext
    {
        public SqlDataContext(IConfiguration configuration) : base(configuration)
        {
            Configuration = configuration;
        }

        public new IConfiguration Configuration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

    }
}
