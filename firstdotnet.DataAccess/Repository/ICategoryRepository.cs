using firstdotnet.Models.Models;

namespace firstdotnet.DataAccess.Repository {
    public interface ICategoryRepository {
        Category GetById(int id);
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
    }
}
