using DbOperationsWithEFCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace DbOperationsWithEFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public LanguageController(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        ////Get All Data of Language Table
        //[HttpGet("LanguageController")]
        //public async Task<IActionResult> GetAllLanguages()
        //{
        //    var result = await (from a in this._appDbContext.Languages select a).ToListAsync();
        //    return Ok(result);
        //}

        ////Get  Data of Language Table based on title
        //[HttpGet("{name:alpha}")]
        //public async Task<IActionResult> FindLanguageAsync([FromRoute] string name)
        //{
        //    var result = await _appDbContext.Languages.FirstOrDefaultAsync(a => a.Title == name);
        //    return Ok(result);
        //}

        ////Get  Data of Language Table based on title and description
        //[HttpGet("{name}/{description}")]
        //public async Task<IActionResult> FindLanguageByTwoParameterAsync([FromRoute] string name, [FromRoute] string description)
        //{
        //    var result = await _appDbContext.Languages.FirstOrDefaultAsync(a => a.Title == name && a.Description == description);
        //    return Ok(result);

        //}

        // ////Get  Data of Language Table based on title and description if it is not null

        //[HttpGet("{name}")]
        //public async Task<IActionResult> FindLanguageByTwoParameterNullAsync([FromRoute] string name, [FromQuery] string? description)
        //{
        //    var result = await _appDbContext.Languages.FirstOrDefaultAsync(a => a.Title == name &&
        //                (string.IsNullOrEmpty(description) ||a.Description == description));
        //    return Ok(result);

        //}

        ////Get all Data of Language Table based on common title
        //[HttpGet("{name}")]

        //public async Task<IActionResult> GetAllCommonLanguageDataAsync([FromRoute] string name)
        //{
        //    var a = await _appDbContext.Languages.Where(a => a.Title == name).ToListAsync();
        //    return Ok(a);
        //}

        ////Get n data based on id enter by user from Language table
        //[HttpPost("all")}
        //public async Task<IActionResult> GetAllEnterIdDataAsync([FromBody] List<int> ids)
        //{
        //    var a = await _appDbContext.Languages.Where(a=>ids.Contains(a.Id)).ToListAsync();
        //    return Ok(a);
        //}

        ////Get n data based on id enter by user from Language table but filter what you want

        [HttpPost("all")]

        public async Task<IActionResult> GetAllCommonLanguageDataAsync([FromBody] List<int> ids)
        {
            //var a = await _appDbContext.Languages
            //       .Where(x => ids.Contains(x.Id))
            //       .Select(x => new Language()
            //       {
            //         Id = x.Id,
            //         Title = x.Title,
            //       }).ToListAsync();

            var a= await (from x in _appDbContext.Languages where ids.Contains(x.Id) 
                          select new
                          {
                              LanguageId = x.Id,
                              Name = x.Title,
                          }).ToListAsync();

            return Ok(a);
        }
    }
}
