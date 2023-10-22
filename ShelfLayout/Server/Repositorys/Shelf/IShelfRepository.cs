using ShelfLayout.Shared.Entities.Repository;

namespace ShelfLayout.Server.Repositorys.Shelf
{
    public interface IShelfRepository
    {
        Task<List<Cabinet>> GetCabinet();
    }
}
