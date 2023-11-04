using ShelfLayout.Shared.Entities.Repository;

namespace ShelfLayout.Server.Repositorys.Shelf
{
    public interface IShelfRepository
    {
        Task<List<UnitCabinet>> GetCabinet(int storeId, int cabinetId);
    }
}
