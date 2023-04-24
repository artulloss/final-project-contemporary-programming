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

        [HttpPost]
        public async Task<ActionResult<MemberInfo>> CreateMemberInfo(MemberInfo memberInfo)
        {
            _context.MemberInfos.Add(memberInfo);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateMemberInfo), new { id = memberInfo.Id }, memberInfo);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MemberInfo>> DeleteMemberInfo(int id)
        {
            var memberInfo = await _context.MemberInfos.FindAsync(id);

            if (memberInfo == null) 
            {
                return NotFound();
            }

            _context.MemberInfos.Remove(memberInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MemberInfo>> UpdateMemberInfo(int id, MemberInfo memberInfo)
        {
            if (id != memberInfo.Id)
            {
                return BadRequest();
            }

            if (!MemberInfoExists(id))
            {
                _context.MemberInfos.Add(memberInfo);
            }
            else
            {
                _context.Entry(memberInfo).State = EntityState.Modified;
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            if (!MemberInfoExists(id))
            {
                return CreatedAtAction(nameof(GetMemberInfo), new { id = memberInfo.Id }, memberInfo);
            }
            else
            {
                return NoContent();
            }
        }

        private bool MemberInfoExists(int id)
        {
            return _context.MemberInfos.Any(e => e.Id == id);
        }
    }    
}