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

        [HttpPost]
        public async Task<ActionResult<Hobby>> CreateHobby(Hobby hobby)
        {
            _context.Hobbies.Add(hobby);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHobby), new { id = hobby.Id }, hobby);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Hobby>> DeleteHobby(int id)
        {
            var hobby = await _context.Hobbies.FindAsync(id);

            if(hobby == null)
            {
                return NotFound();
            }

            _context.Hobbies.Remove(hobby);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Hobby>> UpdateHobby(int id, Hobby hobby)
        {
            if (id != hobby.Id)
            {
                return BadRequest();
            }

            if(!HobbyExists(id))
            {
                _context.Hobbies.Add(hobby);
            }
            else
            {
                _context.Entry(hobby).State = EntityState.Modified;
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            if(!HobbyExists(id))
            {
                return CreatedAtAction(nameof(GetHobby), new {id = hobby.Id }, hobby);
            }
            else
            {
                return NoContent();
            }
        }

        private bool HobbyExists(int id)
        {
            return _context.Hobbies.Any(e => e.Id == id);
        }
    }
}