using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteFoodController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FavoriteFoodController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoriteFood>>> GetFavoriteFoods()
        {
            return await _context.FavoriteFoods.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FavoriteFood>> GetFavoriteFood(int id)
        {
            var favFood = await _context.FavoriteFoods.FindAsync(id);

            if (favFood == null)
            {
                return NotFound();
            }

            return favFood;
        }

        [HttpPost]
        public async Task<ActionResult<FavoriteFood>> CreateFavoriteFood(FavoriteFood favoriteFood)
        {
            // Add the favoriteFood object to the DbSet
            _context.FavoriteFoods.Add(favoriteFood);

            // Save changes to the database asynchronously
            await _context.SaveChangesAsync();

            // Return the created favoriteFood object with a '201 Created' status code
            return CreatedAtAction(nameof(GetFavoriteFood), new { id = favoriteFood.Id }, favoriteFood);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FavoriteFood>> DeleteFavoriteFood(int id)
        {
            var favFood = await _context.FavoriteFoods.FindAsync(id);

            if (favFood == null)
            {
                return NotFound();
            }

            _context.FavoriteFoods.Remove(favFood);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<FavoriteFood>> UpdateFavoriteFood(int id, FavoriteFood favFood)
        {
            // Check if the provided id matches the favFood object's id
            if (id != favFood.Id)
            {
                return BadRequest();
            }

            // Check if the favorite food with the given id exists
            if (!FavoriteFoodExists(id))
            {
                // If it doesn't exist, create a new favorite food
                _context.FavoriteFoods.Add(favFood);
            }
            else
            {
                // If it exists, mark the favFood object as modified
                _context.Entry(favFood).State = EntityState.Modified;
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

            if (!FavoriteFoodExists(id))
            {
                return CreatedAtAction(nameof(GetFavoriteFood), new { id = favFood.Id }, favFood);
            }
            else
            {
                // Return a '204 No Content' status code, indicating the update was successful
                return NoContent();
            }
        }

        private bool FavoriteFoodExists(int id)
        {
            return _context.FavoriteFoods.Any(e => e.Id == id);
        }

    }
}
