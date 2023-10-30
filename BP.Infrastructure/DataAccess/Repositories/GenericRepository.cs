using BP.Infrastructure.Entities;
using BP.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly BPContext _context;
        private readonly DbSet<T> _table;

        public GenericRepository(BPContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public T GetById(object id)
        {
            return _table.Find(id);
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _table.FindAsync(id);
        }

        public void Insert(T obj)
        {
            _table.Add(obj);
        }

        public T Update(T obj)
        {
            var entry = _table.Update(obj);
            return entry.Entity;
        }

        public void Delete(object id)
        {
            T existing = _table.Find(id);
            _table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public DbSet<T> GetTable()
        {
            return _table;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}