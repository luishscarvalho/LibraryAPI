using LibraryAPI.Models;
using LibraryAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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
        if (research == null) { return NotFound(); }
        return Ok(research);
    }

    [HttpPost]
    public IActionResult CreateBook([FromBody] Book newBook)
    {
        var booking = new BookService().CreateBook(newBook);
        return Created($"api/book/{booking.Id}", booking);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateBook([FromBody] Book newBook, int id)
    {
        var bookFound = new BookService().FindBook(id, newBook);
        if (bookFound == null)
        {
            return NotFound();
        }
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        var bookDeleted = new BookService().DeleteBook(id);
        if(bookDeleted == true) 
        {  
            return NoContent(); 
        }
        return NotFound();
    }
}
