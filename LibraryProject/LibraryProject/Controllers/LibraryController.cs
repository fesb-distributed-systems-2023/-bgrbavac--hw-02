using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class LibraryController : ControllerBase
{
    [HttpGet("borrow/book/{bookName}/library/{libraryName}")]
    public IActionResult BorrowBookFromRoute(string bookName, string libraryName)
    {
        return Ok($"Book {bookName} borrowed from {libraryName} Library :: from route");
    }

    [HttpGet("borrow")]
    public IActionResult BorrowBookFromQuery([FromQuery] string bookName, [FromQuery] string libraryName)
    {
        return Ok($"Book {bookName} borrowed from {libraryName} Library :: from query");
    }

    [HttpPost("greet")]
    public IActionResult GreetFromLibrary([FromBody] string libraryName)
    {
        return Ok($"Hello from {libraryName} Library!");
    }
}
