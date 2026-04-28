using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuCategoriesController : ControllerBase
    {
        static List<MenuCategory> categories = new();

        [HttpGet]
        public List<MenuCategory> Get()
        {
            return categories;
        }

        [HttpPost]
        public MenuCategory Add(MenuCategory c)
        {
            categories.Add(c);
            return c;
        }
    }
}