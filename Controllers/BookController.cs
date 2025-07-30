using LibraryAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpGet]
    public IActionResult GetBooks()
    {
        var showcase = new BookService().GetBooks();
        return Ok(showcase);
    }

    [HttpGet("{id}")]
    public IActionResult GetBookById(int id)
    { 
        var research = new BookService().GetBookById(id);
        return Ok(research);
    }
}
