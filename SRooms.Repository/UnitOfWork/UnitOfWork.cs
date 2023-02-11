using System;
using SRooms.Core.UnitOfWorks;

namespace SRooms.Repository.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{

        private readonly AppDbContext appDbContext;

		public UnitOfWork(AppDbContext _appDbContext)
		{
            this.appDbContext = _appDbContext;
		}

        public void Commit()
        {
            appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await appDbContext.SaveChangesAsync();
        }
    }
}

