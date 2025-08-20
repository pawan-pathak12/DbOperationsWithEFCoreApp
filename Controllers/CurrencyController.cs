using DbOperationsWithEFCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //Get All Data of Currency Table
        //[HttpGet("CurrencyController")]
        //public async Task<IActionResult> GetAllCurrencies()
        //{

        //    var result = await _appDbContext.Currencies.ToListAsync();
        //    return Ok(result);
        //}

        //[HttpGet("{id:int}")]
        //public async Task<IActionResult> FindCurrencyAsync([FromRoute] int id)
        //{
        //    var result = await _appDbContext.Currencies.FindAsync(id);
        //    return Ok(result);

        //}

        ////Get  Data of Currency Table based on title
        //[HttpGet("{name:alpha}")]

        //public async Task<IActionResult> FindCurrencyByNameAsync([FromRoute] string name)
        //{
        //    var result= await _appDbContext.Currencies.FirstOrDefaultAsync(a=>a.CurrencyType==name.ToUpper()) ;
        //    return Ok(result);
        //}

        //Get  Data of Currency Table based on title and description

        //[HttpGet("{name}/{description}")]
        //public async Task<IActionResult> FindBooksByTwoParameterAsync([FromRoute] string name, [FromRoute] string description)
        //{
        //    var result = await _appDbContext.Currencies.FirstOrDefaultAsync(a => a.CurrencyType == name && a.Description == description);
        //    return Ok(result);

        //}

        // ////Get  Data of Currency Table based on title and description if it is not null

        //[HttpGet("{name}")]
        //public async Task<IActionResult> FindLanguageByTwoParameterNullAsync([FromRoute] string name, [FromQuery] string? description)
        //{
        //    var result = await _appDbContext.Currencies.FirstOrDefaultAsync(a => a.CurrencyType == name &&
        //                (string.IsNullOrEmpty(description) || a.Description == description));
        //    return Ok(result);

        //}

        ////Get all Data of Currency Table based on common title
        //[HttpGet("{name}")]

        //public async Task<IActionResult> GetAllCommonLanguageDataAsync([FromRoute] string name)
        //{
        //    var a = await _appDbContext.Currencies.Where(a => a.CurrencyType == name).ToListAsync();
        //    return Ok(a);
        //}

        //Get n data based on id enter by user from Currencies table
        //[HttpPost("all")]
        //public async Task<IActionResult> GetAllEnterIdDataAsync([FromBody] List<int> ids)
        //{
        //    var a = await _appDbContext.Currencies.Where(a => ids.Contains(a.Id)).ToListAsync();
        //    return Ok(a);
        //}


    }

}
