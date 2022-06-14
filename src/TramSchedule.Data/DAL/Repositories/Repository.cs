using Microsoft.EntityFrameworkCore;
using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Interfaces;

namespace TramSchedule.Data.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly TramScheduleContext _context;

        public Repository(TramScheduleContext context)
        {
            _context = context;
        }

        public void Add(T entity) => _context.Set<T>().Add(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);

        public T Get(int id) => _context.Set<T>().Find(id);

        public IEnumerable<T> GetAll() => _context.Set<T>().AsNoTracking().ToList();

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}