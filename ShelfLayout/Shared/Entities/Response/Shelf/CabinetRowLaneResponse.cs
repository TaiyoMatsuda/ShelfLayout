namespace ShelfLayout.Shared.Entities.Response.Shelf
{
    public class CabinetRowLaneResponse
    {
        public int Id { get; set; }
        public short LaneNum { get; set; }
        public short Quantity { get; set; }
        public decimal PositionX { get; set; }
        public ProductResponse Product { get; set; } = new ProductResponse();
    }
}
