using ShelfLayout.Shared.Entities.View.Shelf;

namespace ShelfLayout.Shared.Entities.Response.Shelf
{
    public class CabinetResponse
    {
        public int Id { get; set; }

        public decimal PositionX { get; set; }

        public decimal PositionY { get; set; }

        public decimal PositionZ { get; set; }

        public List<CabinetRowResponse> Rows { get; set; } = new List<CabinetRowResponse>();
    }
}
