using ShelfLayout.Shared.Entities.Response.Shelf;

namespace ShelfLayout.Client.Gateway.Shelf
{
    public interface ICabinetGateway
    {
        Task<List<CabinetResponse>> GetAsync(int storeId, int cabinetId);
    }
}
