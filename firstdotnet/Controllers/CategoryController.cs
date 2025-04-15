using firstdotnet.DataAccess.Data;
using firstdotnet.Models.Models;
using Microsoft.AspNetCore.Mvc;
namespace firstdotnet.Controllers {
    public class CategoryController : Controller {
        private ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db) {
            _db = db;
        }
        public IActionResult Index() {

            var categories = _db.Categories.ToList();
            return View(categories);

        }

        public IActionResult Add() {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category data) {
            if (ModelState.IsValid) {
                _db.Categories.Add(data);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id) {

            if (id == null || id == 0) {
                return NotFound();
            }

            Category? category = _db.Categories.Find(id);
            if (category == null) return NotFound();

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category data) {
            if (ModelState.IsValid) {
                _db.Categories.Update(data);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int? id) {
            var category = _db.Categories.Find(id);
            if (category != null) {
                _db.Categories.Remove(category);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
