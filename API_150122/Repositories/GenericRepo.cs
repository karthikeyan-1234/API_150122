using API_150122.Contexts;

using Microsoft.EntityFrameworkCore;

using System.Reflection.Metadata.Ecma335;

namespace API_150122.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        IBusinessDBContext db;
        DbSet<T> table;

        public GenericRepo(IBusinessDBContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }

        public async Task<T> AddAsync(T obj) => (await table.AddAsync(obj)).Entity;

        public async Task<IEnumerable<T>> GetAll() => await table.ToListAsync();

        public void Delete(T obj) => db.Entry(obj).State = EntityState.Deleted;

        public void Update(T obj) => db.Entry(obj).State = EntityState.Modified;

        public Task SaveChangesAsync() => db.SaveChangesAsync();

        public IEnumerable<T> FindAll(Func<T, bool> where) => table.Where(where);
    }
}
