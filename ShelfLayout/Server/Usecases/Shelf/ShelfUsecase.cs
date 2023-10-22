using Microsoft.AspNetCore.Mvc;
using ShelfLayout.Server.Gateways.Shelf;
using ShelfLayout.Shared.Entities.Response.Shelf;

namespace ShelfLayout.Server.Usecases.Shelf
{
    public class ShelfUsecase: IShelfUsecase
    {
        private readonly IShelfGateway _gateway;

        public ShelfUsecase(IShelfGateway gateway)
        {
            _gateway = gateway;
        }

        public async Task<ActionResult<CabinetResponse>> GetCabinet()
        {
            var res = await _gateway.GetCabinet();
            return res;
        }
    }
}
