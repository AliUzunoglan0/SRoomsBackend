﻿using System;
using System.Linq.Expressions;

namespace SRooms.Core.Services
{
	public interface IService<T> where T : class
	{

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<T> AddAsync(T entity);

        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task UpdateAsync(T entity);

        Task RemoveAsync(T entity);

        Task RemoveRangeAsync(IEnumerable<T> entitites);

    }
}

