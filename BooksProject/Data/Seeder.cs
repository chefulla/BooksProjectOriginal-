//using static BooksProject.Data.Seeder;
//using System.Formats.Asn1;
//using System.Globalization;
//using BooksProject.Context;
//using BooksProject.Models.BooksModels;
//using CsvHelper;

//namespace BooksProject.Data
//{
//    public class Seeder
//    {
//        public class BooksSeeder : IBooksSeeder
//        {
//            private const string CsvPath = "C:\\Users\\GRIGS\\Desktop\\API3bestsellers with categories.csv";
//            private readonly Dictionary<string, GenreModel> genres = new();
//            private readonly Dictionary<string, PriceModel> price = new();
//            private readonly Dictionary<string, YearModel> year = new();
//            private readonly Dictionary<string, RatingModel> rating = new();
//            private readonly Dictionary<string, ReviewModel> reviews = new();
//            private readonly AppDbContext AppDbContext;

//            public BooksSeeder(AppDbContext AppDbContext)
//            {
//                this.AppDbContext = AppDbContext;
//            }


//            public async Task SeedAsync()
//            {
//                if (this.AppDbContext.BooksModels.Any())
//                {
//                    using var reader = new StreamReader(CsvPath);

//                    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

//                    csv.Context.RegisterClassMap<BookCSVMap>();

//                    var games = csv.GetRecords<BookCSVModel>();

//                }
//            }
//        }
//    }
//}
