using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberInfoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MemberInfoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberInfo>>> GetMemberInfo()
        {
            return await _context.MemberInfos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MemberInfo>> GetMemberInfo(int id)
        {
            var info = await _context.MemberInfos.FindAsync(id);

            if (info == null)
            {
                return NotFound();
            }

            return info;
        }
    }
}