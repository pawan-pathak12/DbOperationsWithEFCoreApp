using DbOperationsWithEFCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public BooksController(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        //Get All Data of Books Table

        //[HttpGet("BooksController")]
        //public async Task<IActionResult> GetAllBooks()
        //{
        //    var result = await _appDbContext.Books.ToListAsync();
        //    return Ok(result);
        //}

        ////Get  Data of BOoks Table based on id
        //[HttpGet("{id:int}")]
        //public async Task<IActionResult> FindBooksByAsync([FromRoute] int id)
        //{
        //    var a = await _appDbContext.Books.FindAsync(id);
        //    return Ok(a);
        //}

        ////Get  Data of Books Table based on Name
        //[HttpGet("{name:alpha}")]
        //public async Task<IActionResult> FindBOoksByNameAsync([FromRoute] string name)
        //{
        //    var result = await _appDbContext.Books.FirstOrDefaultAsync(a=>a.Title== name);
        //    return Ok(result);
        //}

        //Get  Data of Books Table based on Name and description
        //[HttpGet("{name}/{description}")]
        //public async Task<IActionResult> FindBOoksByTwoParameterAsync([FromRoute] string name, [FromRoute] string description)
        //{
        //    var a = await _appDbContext.Books.FirstOrDefaultAsync(a=>a.Title==name && a.Description==description);
        //    return Ok(a);
        //}

        // ////Get  Data of Language book based on title and description if it is not null

        //[HttpGet("{name}")]
        //public async Task<IActionResult> FindLanguageByTwoParameterNullAsync([FromRoute] string name, [FromQuery] string? description)
        //{
        //    var result = await _appDbContext.Books.FirstOrDefaultAsync(a => a.Title == name &&
        //                (string.IsNullOrEmpty(description) || a.Description == description));
        //    return Ok(result);

        //}

        ////Get all Data of book Table based on common title
        //[HttpGet("{name}")]

        //public async Task<IActionResult> GetAllCommonLanguageDataAsync([FromRoute] string name)
        //{
        //    var a = await _appDbContext.Books.Where(a => a.Title == name).ToListAsync();
        //    return Ok(a);
        //}

        ////Get n data based on id enter by user from Books table
        //[HttpPost("all")]
        //public async Task<IActionResult> GetAllEnterIdDataAsync([FromBody] List<int> ids)
        //{
        //    var a = await _appDbContext.Books.Where(a => ids.Contains(a.Id)).ToListAsync();
        //    return Ok(a);
        //}


    }
}