using firstdotnet.DataAccess.Repository;
using firstdotnet.Models.Models;
using Microsoft.AspNetCore.Mvc;
namespace firstdotnet.Controllers {
    public class CategoryController : Controller {
        private readonly IGenericRepository<Category> _categoryRepo;

        public CategoryController(IGenericRepository<Category> c) {
            _categoryRepo = c;
        }
        public IActionResult Index() {

            var categories = _categoryRepo.GetAll();
            return View(categories);

        }

        public IActionResult Add() {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category data) {
            if (ModelState.IsValid) {
                _categoryRepo.Add(data);
                _categoryRepo.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id) {

            if (id == null || id == 0) {
                return NotFound();
            }
            Category? category = _categoryRepo.GetById(id!);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category data) {
            if (ModelState.IsValid) {
                _categoryRepo.Update(data);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id) {
            _categoryRepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
