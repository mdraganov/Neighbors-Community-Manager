namespace NeighboursCommunitySystem.Services.Data.Contracts
{
    using System.Linq;

    public interface IService<T>
    {
        IQueryable<T> All();
    }
}
