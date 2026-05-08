using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lab1projekt.Data;
using lab1projekt.models;

namespace lab1projekt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuCategoriesController : ControllerBase
    {
        private readonly RestaurantDbContext _context;

        public MenuCategoriesController(RestaurantDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<MenuCategory>>> GetAll()
        {
            return await _context.MenuCategories.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MenuCategory>> GetById(int id)
        {
            var category = await _context.MenuCategories.FindAsync(id);

            if (category == null)
                return NotFound();

            return category;
        }

        [HttpPost]
        public async Task<ActionResult<MenuCategory>> Create(MenuCategory category)
        {
            _context.MenuCategories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = category.Id }, category);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, MenuCategory category)
        {
            if (id != category.Id)
                return BadRequest();

            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _context.MenuCategories.FindAsync(id);

            if (category == null)
                return NotFound();

            _context.MenuCategories.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}