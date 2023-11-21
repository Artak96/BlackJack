using BlackJack.Core.Abstractions.IRepositories;
using BlackJack.Core.Entities;
using BlackJack.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly BlackJackDbContext _context;

        public BaseRepository(BlackJackDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(T entity)
        {
            try
            {
                var user = await _context.Set<T>().AddAsync(entity);
                if (user != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public async Task AddRange(IEnumerable<T> entities)
        {
            try
            {
                _context.Set<T>().AddRange(entities);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }



        public async Task<T> GetById(int id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<T?> GetByIdIncludeAsync(Expression<Func<T, bool>> predicate, string include)
        {
            return await _context.Set<T>().Where(predicate).Include(include).FirstOrDefaultAsync();
        }
  
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return await _context.Set<T>().FirstOrDefaultAsync(predicate);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await  _context.Set<T>().Where(predicate).ToListAsync();
        }
    
        public async Task<bool> RemoveAsync(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public async Task<bool> SaveChangeAsync()
        {
            try
            {
                foreach (var entry in _context.ChangeTracker.Entries())
                {
                    if (entry.Entity is BaseEntity trackable)
                    {
                        var now = DateTime.UtcNow;
                        switch (entry.State)
                        {
                            case EntityState.Modified:
                                trackable.EndTime = now;
                                break;

                            case EntityState.Added:
                                trackable.CreationTime = now;
                                trackable.EndTime = now;
                                break;
                        }
                    }
                }

                await _context.SaveChangesAsync();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch 
            {
                return false; 
            }
        }
    }
}

