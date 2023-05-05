using LidellBackend.Data;
using LidellBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LidellBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScoreController : Controller
    {
        private readonly ScoreDbContext _context;
        public ScoreController(ScoreDbContext scoreDbContext)
        {
            _context = scoreDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllScores()
        {
            var scores = await _context.Scores.ToListAsync();
            return Ok(scores);
        }

        [HttpPost]

        public async Task<IActionResult> PostScore([FromBody] Score scoreRequest)
        {
            scoreRequest.Id = Guid.NewGuid();

            await _context.Scores.AddAsync(scoreRequest);
            await _context.SaveChangesAsync();
            return Ok(scoreRequest);

        }
    }
}
