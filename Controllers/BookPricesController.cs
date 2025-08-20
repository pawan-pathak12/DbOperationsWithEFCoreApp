using DbOperationsWithEFCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookPricesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public BookPricesController(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        //Get All Data of BookPrices Table

        //[HttpGet("BookPricesController")]
        //public async Task<IActionResult> GetAllBookPrices()
        //{
        //    var result = await _appDbContext.BookPrice.ToListAsync();
        //    return Ok(result);
        //}

        ////Get  Data of BookPrices Table based on id

        //[HttpGet("{id:int}")]
        //public async Task<IActionResult> GetBookPricesByAsync([FromRoute] int id)
        //{
        //    var a = await _appDbContext.Languages.FindAsync(id);
        //    return Ok(a);
        //}

        ////Get  Data of BooksPrices Table based on id and amount

        //[HttpGet("{id}/{amount}")]
        //public async Task<IActionResult> FindBookPricesByTwoParameterAsync([FromRoute] int id, [FromRoute] decimal amount)
        //{
        //    var result = await _appDbContext.BookPrice.FirstOrDefaultAsync(a => a.Id == id && ( a.Amount == amount));
        //    return Ok(result);

        //}

        //   ////Get all Data of BOokPrices Table based on common id
        //[HttpGet("{id}")]

        //public async Task<IActionResult> GetAllCommonLanguageDataAsync([FromRoute] int id)
        //{
        //    var a = await _appDbContext.BookPrice.Where(a => a.BookId == id).ToListAsync();
        //    return Ok(a);
        //}

        ////Get n data based on id enter by user from BookPrices table
        //[HttpPost("all")]
        //public async Task<IActionResult> GetAllEnterIdDataAsync([FromBody] List<int> ids)
        //{
        //    var a = await _appDbContext.BookPrice.Where(a => ids.Contains(a.Id)).ToListAsync();
        //    return Ok(a);
        //}

        ////Get n data based on id enter by user from BookPrice table but filter what you want
        [HttpPost("all")]

        public async Task<IActionResult> GetAllEnterIdDataWithFilterAsync(List<int> ids)
        {
            //    var a = await _appDbContext.BookPrice.Where(x => ids.Contains(x.Id)).Select(x => new BookPrice
            //    { Id=x.Id , 
            //    BookId = x.BookId ,
            //    }).ToListAsync();

            var a = await (from x in _appDbContext.BookPrice
                           where ids.Contains(x.Id)
                           select new
                           {
                               BookId = x.Id,
                               CurrencyId = x.Currency,
                           }).ToListAsync();
            return Ok(a);
    }

}

}
