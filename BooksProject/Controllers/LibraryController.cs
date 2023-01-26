using BooksProject.Context;
using BooksProject.Data;
using BooksProject.Models.BooksModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BooksProject.Controllers
{
    [Route("api")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private AppDbContext _appDbContext;

        public LibraryController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var res = _appDbContext.AuthorBooks.Include(a => a.Author).Include(b => b.Book).ToList();

            return Ok(res);
        }

        [Authorize]
        [HttpGet("GetAuthors")]

        public IActionResult GetAuthors()
        {

            var res = _appDbContext.Authors.Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
            });

            return Ok(res);
        }

        [HttpGet("GetBooks")]

        public IActionResult GetBooks()
        {

            var res = _appDbContext.Books.Select(x => new
            {
                Id = x.Id,
                Title = x.Title,
            });

            return Ok(res);
        }

        [HttpGet("CertainBook")]
        public IActionResult CertainBook([FromRoute] int id)
        {
            var res = _appDbContext.Books.Where(x => x.Id == id).First();
            return Ok(res);
        }

        [HttpGet("CertainAuthor")]
        public IActionResult CertainAuthor([FromRoute] int id)
        {
            var res = _appDbContext.Authors.Where(x => x.Id == id).First();
            return Ok(res);
        }

        [HttpGet("CertainAuthorBook")]
        public IActionResult CertainAuthorBook([FromRoute]int id)
        {
            var res = _appDbContext.AuthorBooks.Where(x => x.AuthorId == id).First();
            return Ok(res);
        }

        [HttpPost("PostBook")]
        public IActionResult PostBook(Book item)
        {
            var res = _appDbContext.Books.Add(item);
            return Ok(res);
        }

        [HttpDelete("DeleteBook")]

        public IActionResult DeleteBook([FromRoute]int id)
        {
            var res = _appDbContext.Books.First(x => x.Id == id);
            _appDbContext.Books.Remove(res);
            return Ok();
        }

        //[HttpGet("Books2")]
        //public ActionResult GetAll()
        //{
        //    var index = _libraryContext.Authors.Include(c => c.Book);
        //    return 
        //}


        //[HttpGet("AuthorsId")]
        //public string GetAuthorId(int id)
        //{
        //    return _libraryContext.Authors.FirstOrDefault(z => z.Id == id)
        //}


        [HttpPost("AuthorPost")]
        public void Post([FromBody] Author author)
        {
            _appDbContext.Authors.Add(author);
            _appDbContext.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
