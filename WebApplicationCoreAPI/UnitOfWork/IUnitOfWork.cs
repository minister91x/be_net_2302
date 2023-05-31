using UnitOfWork.DataAccess.Repository;

namespace WebApplicationCoreAPI.UnitOfWork
{
    public interface IUnitOfWork
    {
        ProductRepository Products { get; }
        EmployeerRepository employeer { get; }
        int Save();
    }
}
