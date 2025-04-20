using firstdotnet.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace firstdotnet.DataAccess.Repository {
    public class GenericRepository<T> : IGenericRepository<T> where T : class {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context) {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T item) {
            _dbSet.Add(item);
        }

        public void Delete(int id) {
            var item = _dbSet.Find(id);
            if (item != null) {
                _dbSet.Remove(item);
            }
            _context.SaveChanges();
        }

        public List<T> GetAll() {
            return _dbSet.ToList();
        }

        public T GetById(int id) {
            return _dbSet.Find(id);
        }

        public void Update(T item) {
            _dbSet.Update(item);
        }

        public void Save() {
            _context.SaveChanges();
        }
    }
}
