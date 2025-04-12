using firstdotnet.Data;
using firstdotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstdotnet.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db){
            _db = db;
        }
        public IActionResult Index()
        {
            var categories = _db.Categories.ToList();
            Console.WriteLine("✅ DB connection successful. Categories count: " + categories.Count);

            return View();
        }
    }
}
