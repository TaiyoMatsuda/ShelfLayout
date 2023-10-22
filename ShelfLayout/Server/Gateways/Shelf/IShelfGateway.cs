using Microsoft.AspNetCore.Mvc;
using ShelfLayout.Shared.Entities.Response.Shelf;

namespace ShelfLayout.Server.Gateways.Shelf
{
    public interface IShelfGateway
    {
        Task<ActionResult<CabinetResponse>> GetCabinet();
    }
}
