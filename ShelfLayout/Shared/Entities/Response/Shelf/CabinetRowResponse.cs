using ShelfLayout.Shared.Entities.Repository;

namespace ShelfLayout.Shared.Entities.Response.Shelf
{
    public class CabinetRowResponse
    {
        public int Id { get; set; }

        public short RowNum { get; set; }

        public decimal PositionZ { get; set; }

        public decimal SizeZ { get; set; }

        public List<CabinetRowLaneResponse> CabinetLanes { get; set; } = new List<CabinetRowLaneResponse>();
    }
}
