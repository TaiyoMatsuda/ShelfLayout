using ShelfLayout.Shared.Entities.Response.Shelf;

namespace ShelfLayout.Server.Usecases.Shelf
{
    public interface IShelfUsecase
    {
        Task<CabinetResponse> GetCabinet(int storeId, int cabinetId);
    }
}
