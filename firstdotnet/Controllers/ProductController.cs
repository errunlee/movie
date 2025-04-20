using firstdotnet.DataAccess.Repository;
using firstdotnet.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstdotnet.Controllers {
    public class ProductController : Controller {
        private IGenericRepository<Product> _repository;
        public ProductController(IGenericRepository<Product> repo) {
            _repository = repo;
        }
        public IActionResult Index() {
            var products = _repository.GetAll();
            return View(products);
        }

        public IActionResult Add() {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product) {
            if (ModelState.IsValid) {
                _repository.Add(product);
                _repository.Save();
                return RedirectToAction("Index");
            }
            else {
                return View();
            }

            return RedirectToAction("Index");
        }
    }
}
