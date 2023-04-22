using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HobbyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HobbyController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hobby>>> GetHobbies()
        {
            return await _context.Hobbies.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hobby>> GetHobby(int id)
        {
            var hobby = await _context.Hobbies.FindAsync(id);

            if (hobby == null)
            {
                return NotFound();
            }

            return hobby;
        }
    }
}