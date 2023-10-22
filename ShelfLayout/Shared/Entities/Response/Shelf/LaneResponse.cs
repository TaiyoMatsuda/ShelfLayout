using ShelfLayout.Shared.Entities.View;

namespace ShelfLayout.Shared.Entities.Response.Shelf
{
    public class LaneResponse
    {
        public int Id { get; set; }

        public short RowNumber { get; set; }

        public short LaneNumber { get; set; }

        public ProductResponse Product { get; set; }

        public short Quantity { get; set; }
    }
}
