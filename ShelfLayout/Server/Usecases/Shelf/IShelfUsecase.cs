using Microsoft.AspNetCore.Mvc;
using ShelfLayout.Shared.Entities.Response.Shelf;

namespace ShelfLayout.Server.Usecases.Shelf
{
    public interface IShelfUsecase
    {
        Task<List<CabinetResponse>> GetCabinet();
    }
}
