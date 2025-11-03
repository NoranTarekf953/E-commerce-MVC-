using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositries.Generic
{
    public class GenericRepo<T>:IGenericRepo<T>
        where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public  async Task<IEnumerable<T>> GetAll(Func<IQueryable<T>, IQueryable<T>>? include = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if(include != null)
            {
                query = include(query);

            }
            return await query.ToListAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _context.Set<T>().Update( entity);
            await SaveChangeAsync();
            return entity;

        }

        public async Task Delete(int id)
        {
            T? entity = _context.Set<T>().Find(id);
            if(entity is not  null)
            {
                _context.Set<T>().Remove(entity);
                await SaveChangeAsync();
            }
        }

        public async Task SaveChangeAsync()
        =>
             await _context.SaveChangesAsync();
        
    }
}
