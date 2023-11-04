using ShelfLayout.Server.Repositorys.Shelf;
using ShelfLayout.Shared.Entities.Response;
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

        public async Task<List<CabinetResponse>> GetCabinet(int storeId, int cabinetId)
        {
            var unitCabinets = await _repository.GetCabinet(storeId, cabinetId);

            var cabinetResponses = unitCabinets
            .GroupBy(uc => uc.CabinetId)
            .Select(cg => new CabinetResponse
            {
                Id = cg.Key,
                PositionX = cg.First().CabinetPositionX,
                PositionY = cg.First().CabinetPositionY,
                PositionZ = cg.First().CabinetPositionZ,
                Lanes = cg
                    .GroupBy(l => l.CabinetRowLaneId)
                    .Select(lg => new LaneResponse
                    {
                        Id = lg.Key,
                        RowNumber = lg.First().RowNum,
                        RowPositionZ = lg.First().RowPositionZ,
                        RowSizeZ = lg.First().RowSizeZ,
                        LaneNumber = lg.First().LaneNum,
                        Quantity = lg.First().Quantity,
                        Product = new ProductResponse
                        {
                            JanCode = lg.First().JanCode,
                            Name = lg.First().ProductName,
                            Volume = lg.First().ProductVolume,
                            SizeX = lg.First().ProductSizeX,
                            SizeY = lg.First().ProductSizeY,
                            SizeZ = lg.First().ProductSizeZ,
                            ImageUrl = lg.First().ProductImageUrl
                        }
                    }).ToList()
            }).ToList();

            return cabinetResponses;
        }
    }
}
