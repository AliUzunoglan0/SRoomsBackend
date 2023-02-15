using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SRooms.Core.Repositories;
using SRooms.Core.Services;
using SRooms.Core.UnitOfWorks;
using SRooms.Repository.Repositories;

namespace SRooms.Service.Services
{
	public class Service<T> : IService<T> where T : class
    {

        private readonly IGenericRepository<T> genericRepository;
        private readonly IUnitOfWork unitOfWork;

        public Service(IGenericRepository<T> genericRepository, IUnitOfWork unitOfWork)
        {
            this.genericRepository = genericRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<T> AddAsync(T entity)
        {
            await genericRepository.AddAsync(entity);
            await unitOfWork.CommitAsync();

            return entity;

        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await genericRepository.AddRangeAsync(entities);
            await unitOfWork.CommitAsync();

            return entities;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await genericRepository.AnyAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await genericRepository.GetAll().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await genericRepository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            genericRepository.Remove(entity);
            await unitOfWork.CommitAsync();

        }

        public async Task RemoveRangeAsync(IEnumerable<T> entitites)
        {
            genericRepository.RemoveRange(entitites);
            await unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            genericRepository.Update(entity);
            await unitOfWork.CommitAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return genericRepository.Where(expression);
        }
    }
}

