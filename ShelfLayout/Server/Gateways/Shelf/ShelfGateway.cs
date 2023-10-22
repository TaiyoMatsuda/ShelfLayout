using Microsoft.AspNetCore.Mvc;
using ShelfLayout.Shared.Entities.Response.Shelf;

namespace ShelfLayout.Server.Gateways.Shelf
{
    public class ShelfGateway: IShelfGateway
    {
        //private readonly IShelfGateway _gateway;

        //public ShelfGateway(IShelfGateway gateway)
        //{
        //    _gateway = gateway;
        //}

        public async Task<ActionResult<CabinetResponse>> GetCabinet()
        {
            //var res = await _gateway.GetCabinet();
            return null;
        }
    }
}
