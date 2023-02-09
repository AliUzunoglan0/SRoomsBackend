using System;
namespace SRooms.Core.UnitOfWorks
{
	public interface IUnitOfWork
	{

		Task CommitAsync();

		void Commit();
	}
}

