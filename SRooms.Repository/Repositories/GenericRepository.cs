using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SRooms.Core.Repositories;

namespace SRooms.Repository.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        protected readonly AppDbContext mContext;
        private readonly DbSet<T> _dBSet;

		public GenericRepository(AppDbContext _context)
		{

            this.mContext = _context;
            _dBSet = mContext.Set<T>();

		}

        public async Task AddAsync(T entity)
        {
            await _dBSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dBSet.AddRangeAsync(entities);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dBSet.AnyAsync(expression);
        }

        public IQueryable<T> GetAll()
        {
            return _dBSet.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dBSet.FindAsync(id);
        }

        public void Remove(T entity)
        {
            _dBSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entitites)
        {
            _dBSet.RemoveRange(entitites);
        }

        public void Update(T entity)
        {
            _dBSet.Update(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dBSet.Where(expression);
        }
    }
}

