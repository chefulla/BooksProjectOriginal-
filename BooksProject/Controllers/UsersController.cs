
using BooksProject.Models;
using Microsoft.AspNetCore.Mvc;

using BooksProject.Models;
using AutoMapper;
using Microsoft.Extensions.Options;
using BooksProject.Authorization;
using BooksProject.Helpers;
using BooksProject.Models.Users;
using BooksProject.Helpers;
using BooksProject.Models.Users;
using Microsoft.AspNetCore.Authorization;
using LibraryOnline.Services;
using AuthorizeAttribute = BooksProject.Authorization.AuthorizeAttribute;

[Authorize]
[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private IUserService _userService;
    private IMapper _mapper;
    private readonly AppSettings _appSettings;

    public UsersController(
        UserService userService,
        IMapper mapper,
        IOptions<AppSettings> appSettings)
    {
        _userService = userService;
        _mapper = mapper;
        _appSettings = appSettings.Value;
    }

    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate(AuthenticateRequest model)
    {
        var response = _userService.Authenticate(model);
        return Ok(response);
    }

    [AllowAnonymous]
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest model)
    {
        _userService.Register(model);
        return Ok(new { message = "Registration successful" });
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _userService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _userService.GetById(id);
        return Ok(user);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateRequest model)
    {
        _userService.Update(id, model);
        return Ok(new { message = "User updated successfully" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _userService.Delete(id);
        return Ok(new { message = "User deleted successfully" });
    }

    [AllowAnonymous]
    [HttpGet("getTxt")]
    public IActionResult GetTxt(string name)
    {
        //using StreamWriter userFileTxt = new(name + ".txt", append: true);
        //userFileTxt.Write(_userService.GetAll());
        //userFileTxt.Close();
        //return Ok();

        System.IO.StreamWriter writer = System.IO.File.CreateText(name + ".txt");
        writer.WriteLine(_userService.GetAll());
        writer.Close();
        return Ok();
    }
}