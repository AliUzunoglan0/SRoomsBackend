using System;
using System.Linq.Expressions;

namespace SRooms.Core.Repositories
{
	public interface IGenericRepository<T> where T : class
	{
        // productRepository.where(x=>x.id>5).OrderBy.ToList() veya Tolistasync methodu çağrılabilir;
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

        Task<T> GetByIdAsync(int id);

		// productRepository.where(x=>x.id>5).OrderBy.ToListAsync();
		IQueryable<T> Where(Expression<Func<T, bool>> expression);

		Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

		//update add methoduna göre daha kısa bi işlem olduğu için async olmasına gerek yoktur.
		void Update(T entity);

		void Remove(T entity);

		void RemoveRange(IEnumerable<T> entitites);

    }
}

