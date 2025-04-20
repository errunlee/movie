using firstdotnet.DataAccess.Data;
using firstdotnet.Models.Models;

namespace firstdotnet.DataAccess.Repository {
    public class CategoryRepository : ICategoryRepository {
        private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext db) {
            _context = db;
        }

        public void Add(Category category) {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id) {
            var category = _context.Categories.Find(id);
            if (category != null) {
                _context.Categories.Remove(category);
            }
            _context.SaveChanges();
        }

        public List<Category> GetAll() {
            return _context.Categories.ToList();
        }

        public Category GetById(int id) {
            var item = _context.Categories.Find(id);
            if (item != null) {
                return item;
            }
            else {
                return null;
            }
        }

        public void Update(Category category) {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }


    }
}
