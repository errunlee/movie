namespace firstdotnet.DataAccess.Repository {
    public interface IGenericRepository<T> {
        T GetById(int id);
        List<T> GetAll();
        void Add(T category);
        void Update(T category);
        void Delete(int id);

        void Save();
    }
}
