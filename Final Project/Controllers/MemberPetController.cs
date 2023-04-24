using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberPetController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MemberPetController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberPet>>> GetMemberPets()
        {
            return await _context.MemberPets.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MemberPet>> GetMemberPets(int id)
        {
            var memberPet = await _context.MemberPets.FindAsync(id);

            if (memberPet == null)
            {
                return NotFound();
            }

            return memberPet;
        }
        [HttpPost]
        public async Task<ActionResult<MemberPet>> CreateMemberPet(MemberPet memberPet)
        {
            // Add the MemberPets object to the DbSet
            _context.MemberPets.Add(memberPet);

            // Save changes to the database asynchronously
            await _context.SaveChangesAsync();

            // Return the created memberPet object with a '201 Created' status code
            return CreatedAtAction(nameof(GetMemberPets), new { id = memberPet.Id }, memberPet);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<MemberPet>> DeleteMemberPet(int id)
        {
            var memberPet = await _context.MemberPets.FindAsync(id);

            if (memberPet == null)
            {
                return NotFound();
            }

            _context.MemberPets.Remove(memberPet);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<MemberPet>> UpdateMemberPet(int id, MemberPet memberPet)
        {
            // Check if the provided id matches the memberPet object's id
            if (id != memberPet.Id)
            {
                return BadRequest();
            }

            // Check if the member Pet with the given id exists
            if (!MemberPetExists(id))
            {
                // If it doesn't exist, create a new favorite food
                _context.MemberPets.Add(memberPet);
            }
            else
            {
                // If it exists, mark the memberPet object as modified
                _context.Entry(memberPet).State = EntityState.Modified;
            }

            try
            {
                // Save changes to the database asynchronously
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            if (!MemberPetExists(id))
            {
                return CreatedAtAction(nameof(GetMemberPets), new { id = memberPet.Id }, memberPet);
            }
            else
            {
                // Return a '204 No Content' status code, indicating the update was successful
                return NoContent();
            }
            
        }
            private bool MemberPetExists(int id)
            {
                return _context.MemberPets.Any(e => e.Id == id);
            }
    }
}
