using ShelfLayout.Shared.Entities.Response;

namespace ShelfLayout.Shared.Entities.View.Shelf
{
    public class CabinetRowLaneView
    {
        public int Id { get; set; }
        public short LaneNum { get; set; }
        public short Quantity { get; set; }
        public decimal PositionX { get; set; }
        public ProductResponse Product { get; set; } = new ProductResponse();
    }
}
