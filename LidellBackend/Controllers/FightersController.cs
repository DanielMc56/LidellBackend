using LidellBackend.Data;
using LidellBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LidellBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FightersController : Controller
    {
        private readonly FighterDbContext _fighterDbContext;

        public FightersController(FighterDbContext fighterDbContext)
        {
            _fighterDbContext = fighterDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFighters()
        {
            var fighters = await _fighterDbContext.Fighters.ToListAsync();
            return Ok(fighters);
        }

        [HttpPost]

        public async Task<IActionResult> AddFighter([FromBody] Fighter fighterRequest)
        {
            fighterRequest.Id = Guid.NewGuid();
            await _fighterDbContext.Fighters.AddAsync(fighterRequest);
            await _fighterDbContext.SaveChangesAsync();
            return Ok(fighterRequest);
        }
    }
}