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
    }
}
