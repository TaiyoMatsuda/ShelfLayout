using Microsoft.AspNetCore.Mvc;
using ShelfLayout.Server.Repositorys.Shelf;
using ShelfLayout.Shared.Entities.Response.Shelf;

namespace ShelfLayout.Server.Usecases.Shelf
{
    public class ShelfUsecase: IShelfUsecase
    {
        private readonly IShelfRepository _repository;

        public ShelfUsecase(IShelfRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<CabinetResponse>> GetCabinet()
        {
            var cabinets = await _repository.GetCabinet();

            var cabinetsResponses = new List<CabinetResponse>();
            //autoMapperを使用するべき
            cabinets.ForEach(x =>
            {
                var cabinetsResponse = new CabinetResponse()
                {
                    //Id = x.Id,
                    //PositionX = x.PositionX,
                    //PositionY = x.PositionY,
                    //PositionZ = x.PositionZ,
                };
                cabinetsResponses.Add(cabinetsResponse);
            });
            return cabinetsResponses;
        }
    }
}
