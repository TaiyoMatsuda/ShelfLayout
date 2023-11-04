namespace ShelfLayout.Shared.Entities.View.Shelf
{
    public class LaneView
    {
        public int Id { get; set; }
        
        public short RowNumber { get; set; }
        
        public short LaneNumber { get; set; }

        public ProductView Product { get; set; } = new ProductView();

        public short Quantity { get; set; }
    }
}
