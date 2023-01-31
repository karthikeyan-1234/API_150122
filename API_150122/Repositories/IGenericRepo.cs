namespace API_150122.Repositories
{
    public interface IGenericRepo<T>
    {
        Task<T> AddAsync(T obj);
        Task<IEnumerable<T>> GetAll();
        void Delete(T obj);
        void Update(T obj);
        Task SaveChangesAsync();
        IEnumerable<T> FindAll(Func<T, bool> where);
    }
}
